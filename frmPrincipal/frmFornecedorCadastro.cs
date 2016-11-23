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
    public partial class frmFornecedorCadastro : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();

        public frmFornecedorCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtTipoProduto.Text != "") && (txtPrazoPagamento.Text != "") && (txtCidade.Text != ""))
            {
                con = banco.abrir_conexao();

                string nome = txtNome.Text;
                string telefone = mkdTelefone.Text;
                string celular = mkdCelular.Text;
                string cidade = txtCidade.Text;
                string tipoProduto = txtTipoProduto.Text;
                int prazoPagamento = Convert.ToInt32(txtPrazoPagamento.Text);

                string inserir = @"INSERT INTO Fornecedor (nomeFor, telFor, celFor, cidadeFor, tipoProdutoFor, prazoPagamentoFor) VALUES ('" + nome + "', '" + telefone + "', '" + celular + "','" + cidade + "', '" + tipoProduto + "', '" + prazoPagamento + "' )";

                //execulta comando SQL
                SqlCommand cmd = new SqlCommand(inserir, con);

                //execulta a gravação na tabela
                cmd.ExecuteNonQuery();

                //exibe mensagem
                MessageBox.Show("Dados salvos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa os campos
                txtCidade.Clear();
                mkdTelefone.Clear();
                mkdCelular.Clear();
                txtCidade.Clear();
                txtTipoProduto.Clear();
                txtPrazoPagamento.Clear();

                //deixa o mouse no nome
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos obrigatórios foram preenchidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
