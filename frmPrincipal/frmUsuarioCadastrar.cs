using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmUsuarioCadastrar : Form
    {
        public frmUsuarioCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (mkdCelular.Text != "") && (txtLogin.Text != "" && (txtSenha.Text != "") && (cbPermissao.Text != "")))
            {
                string nome = txtNome.Text;
                string data = Convert.ToString(dtDataNasc.Text);
                string cidade = txtCidade.Text;
                string rua = txtRua.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                string bairro = txtBairro.Text;
                string telefone = mkdTelefone.Text;
                string celular = mkdCelular.Text;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                string permissao = cbPermissao.Text;

               
                    //conexao com o banco de dados
                    Conexao banco = new Conexao();
                    SqlConnection con;
                    con = banco.abrir_conexao();

                    Verificacao v = new Verificacao();

                //verificar se já existe esse login no banco
                if (v.verificaBanco(login))
                {
                    try
                    {
                        //salvando os dados no banco de dados
                        string inserir = @"INSERT INTO Usuario (nomeUsu, nascimentoUsu, cidadeUsu, ruaUsu, numeroUsu, bairroUsu, telUsu, celUsu, login, senha, tipoPermissao) VALUES ('" + nome + "', '" + data + "', '" + cidade + "', '" + rua + "', '" + numero + "', '" + bairro + "', '" + telefone + "', '" + celular + "', '" + login + "', '" + senha + "', '" + permissao + "' )";

                        //executa o comando SQL
                        SqlCommand cmd = new SqlCommand(inserir, con);
                        cmd.ExecuteNonQuery();

                        //fecha conexao com o banco
                        banco.fecha_conexao();

                        //exibe mensagem de salva com sucesso
                        MessageBox.Show("Dados salvos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //limpa os dados preenchidos
                        txtNome.Clear();
                        txtCidade.Clear();
                        txtRua.Clear();
                        txtNumero.Clear();
                        txtBairro.Clear();
                        mkdTelefone.Clear();
                        mkdCelular.Clear();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        cbPermissao.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na execução do programa \n Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Esse nome de usuário já esta sendo usado, escolha um diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtNumero.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
    }
}

