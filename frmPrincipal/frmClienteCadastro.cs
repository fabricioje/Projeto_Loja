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
    public partial class frmClienteCadastro : Form
    {
        public frmClienteCadastro()
        {
            InitializeComponent();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            //verifica se os campos obrigatórios foram preenchidos
            if((txtNome.Text != "") && (txtNomeMae.Text != "") && (mkdCPF.Text != "") && (txtRua.Text != "") && (txtNumero.Text != "") && (txtBairro.Text != "") && (mkdCelular.Text != ""))
            {
                string nome = txtNome.Text;
                string nomeMae = txtNomeMae.Text;
                string cpf = mkdCPF.Text.Replace(",","").Replace("-","");
                string dataNascimento = dtpDataNascimento.Text;
                string cidade = txtCidade.Text;
                string rua = txtRua.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                string bairro = txtBairro.Text;
                string referencia = txtReferencia.Text;
                string tel = mkdTelefone.Text;
                string cel = mkdCelular.Text;
                int limiteCredito = Convert.ToInt32(txtLimiteCredito.Text);

                try
                {
                    //conexao com o banco de dados
                    Conexao banco = new Conexao();
                    SqlConnection con;
                    con = banco.abrir_conexao();

                    //salvando os dados no banco de dados
                    string inserir = @"INSERT INTO Cliente (nomeCli, maeCli, cpfCli,dataNascimentoCli, cidadeCli, ruaCli, numeroCli, bairroCli, referenciaCli, telCli, celCli, limiteCreditoCli) VALUES ('" + nome + "', '" + nomeMae + "','" + cpf + "','" + dataNascimento + "','" + cidade + "','" + rua + "','" + numero + "','" + bairro + "','" + referencia + "','" + tel + "', '" + cel + "','" + limiteCredito + "')";

                    //execultando o comando SQL
                    SqlCommand cmd = new SqlCommand(inserir, con);
                    cmd.ExecuteNonQuery();

                    //fecha conexao com o banco
                    banco.fecha_conexao();

                    //exibe mensagem de gravado com sucesso
                    MessageBox.Show("Dados salvos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //limpa os campos empreenchidos
                    txtNome.Clear();
                    txtNomeMae.Clear();
                    mkdCPF.Clear();
                    txtCidade.Clear();
                    txtRua.Clear();
                    txtNumero.Clear();
                    txtBairro.Clear();
                    txtReferencia.Clear();
                    mkdTelefone.Clear();
                    mkdCelular.Clear();
                    txtLimiteCredito.Clear();

                    //deixar o curso no primeiro campo
                    txtNome.Focus();
                }catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na execução do do programa. \n" + ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("Verifique se todos os campos obrigatórios foram preenchidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpa os campos empreenchidos
            txtNome.Clear();
            txtNomeMae.Clear();
            mkdCPF.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtReferencia.Clear();
            mkdTelefone.Clear();
            mkdCelular.Clear();
            txtLimiteCredito.Clear();

            //deixar o curso no primeiro campo
            txtNome.Focus();
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

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtLimiteCredito.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
    }
}
