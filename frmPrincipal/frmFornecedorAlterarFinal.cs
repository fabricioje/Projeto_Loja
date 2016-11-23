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
    public partial class frmFornecedorAlterarFinal : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        int id;
        public frmFornecedorAlterarFinal()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void recebeDados(int recebeID, string recebeNome, string recebeTelefone, string recebeCelular, string recebeCidade, string recebeTipoProduto, int recebePrazoPagamento)
        {
            id = recebeID;
            txtNome.Text = recebeNome;
            mkdTelefone.Text = recebeTelefone;
            mkdCelular.Text = recebeCelular;
            txtCidade.Text = recebeCidade;
            txtTipoProduto.Text = recebeTipoProduto;
            txtPrazoPagamento.Text = Convert.ToString(recebePrazoPagamento);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string telefone = mkdTelefone.Text;
                string celular = mkdCelular.Text;
                string cidade = txtCidade.Text;
                string tipoProduto = txtTipoProduto.Text;
                int prazoPagamento = Convert.ToInt32(txtPrazoPagamento.Text);

                string atualiza = @"UPDATE Fornecedor SET nomeFor='" + nome + "',telFor='" + telefone + "',celFor='" + celular + "',cidadeFor='" + cidade + "',tipoProdutoFor='" + tipoProduto + "',prazoPagamentoFor='" + prazoPagamento + "' WHERE idFor='" + id + "' ";
                SqlCommand cmd = new SqlCommand(atualiza, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Atualização realizada com sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na execução do programa. \n Erro: " + ex.Message);
            }
            
        }

        private void txtPrazoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtPrazoPagamento.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mkdTelefone.Clear();
            mkdCelular.Clear();
            txtCidade.Clear();
            txtPrazoPagamento.Clear();
            txtTipoProduto.Clear();
        }
    }
}
