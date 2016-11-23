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
    public partial class frmClienteAlterarFinal : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;
        public frmClienteAlterarFinal()
        {
            InitializeComponent();
            con = banco.abrir_conexao();

        }

        public void recebeDados(int recebeId, string recebeNome, string recebeNomeMae, string recebeCPF, string recebeDataNascimento, string recebeCidade, string recebeRua, int recebeNumero, string recebeBairro, string recebeReferencia, string recebeTel, string recebeCel, double recebeLimite)
        {
            txtID.Text = Convert.ToString(recebeId);
            txtNome.Text = recebeNome;
            txtNomeMae.Text = recebeNomeMae;
            mkdCPF.Text = recebeCPF;
            dtpDataNascimento.Text = recebeDataNascimento;
            txtCidade.Text = recebeCidade;
            txtRua.Text = recebeRua;
            txtNumero.Text = Convert.ToString(recebeNumero);
            txtBairro.Text = recebeBairro;
            txtReferencia.Text = recebeReferencia;
            mkdTelefone.Text = recebeTel;
            mkdCelular.Text = recebeCel;
            txtLimiteCredito.Text = Convert.ToString(recebeLimite);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //cria variáveis para armazenar os dados coletados do formulário frmClienteCadastro
            int id = Convert.ToInt32(txtID.Text);
            string nome = txtNome.Text;
            string nomeMae = txtNomeMae.Text;
            string cpf = mkdCPF.Text;
            string dataNascimento = dtpDataNascimento.Text;
            string rua = txtRua.Text;
            int numero = Convert.ToInt32(txtNumero.Text);
            string bairro = txtBairro.Text;
            string referencia = txtReferencia.Text;
            string telefone = mkdTelefone.Text;
            string celular = mkdCelular.Text;
            double limiteCredito = Convert.ToDouble(txtLimiteCredito.Text);

            try
            {
                //comando SQL para atualizar os dados no bando de dados
                string atualiza = @"UPDATE Cliente SET nomeCli = '" + nome + "', maeCli = '" + nomeMae + "', cpfCli = '" + cpf + "', dataNascimentoCli = '" + dataNascimento + "', ruaCli = '" + rua + "', numeroCli = '" + numero + "', bairroCli = '" + bairro + "', referenciaCli = '" + referencia + "', telCli = '" + telefone + "', celCli = '" + celular + "', limiteCreditoCli = '" + limiteCredito + "' WHERE idCli = '" + id + "' ";
                SqlCommand cmd = new SqlCommand(atualiza, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Atualização realizada com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na execução do programa. \n Erro: " + ex.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
    }
}
