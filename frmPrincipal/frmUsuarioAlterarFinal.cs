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
    public partial class frmUsuarioAlterarFinal : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        public frmUsuarioAlterarFinal()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void recebeDados(int recebeID, string recebeNome, string recebeData, string recebeCidade, string recebeRua, int recebeNumero, string recebeBairro, string recebeTelefone, string recebeCelular, string recebeLogin, string recebeSenha, string recebePermissao)
        {
            txtID.Text = Convert.ToString(recebeID);
            txtNome.Text = recebeNome;
            dtDataNasc.Text = recebeData;
            txtCidade.Text = recebeCidade;
            txtRua.Text = recebeRua;
            txtNumero.Text = Convert.ToString(recebeNumero);
            txtBairro.Text = recebeBairro;
            mkdTelefone.Text = recebeTelefone;
            mkdCelular.Text = recebeCelular;
            txtLogin.Text = recebeLogin;
            txtSenha.Text = recebeSenha;
            cbPermissao.Text = recebePermissao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nome = txtNome.Text;
            string data = dtDataNasc.Text;
            string cidade = txtCidade.Text;
            string rua = txtRua.Text;
            int numero = Convert.ToInt32(txtNumero.Text);
            string bairro = txtBairro.Text;
            string telefone = mkdTelefone.Text;
            string celular = mkdCelular.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string permissao = cbPermissao.Text;

            Verificacao v = new Verificacao();

            //verifica se já existe esse login no banco
            if (v.verificaBanco(login))
            {
                try
                {
                    string atualizar = @"UPDATE Usuario SET nomeUsu = '" + nome + "', nascimentoUsu = '" + data + "', cidadeUsu = '" + cidade + "', ruaUsu = '" + rua + "', numeroUsu = '" + numero + "', bairroUsu = '" + bairro + "', telUsu = '" + telefone + "', celUsu = '" + celular + "', login = '" + login + "', senha = '" + senha + "', tipoPermissao = '" + permissao + "' WHERE idUsuario = '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(atualizar, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Atualização realizada com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na execução do programa. \n Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Esse nome de usuário já esta sendo usado, escolha um diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
    }
}
