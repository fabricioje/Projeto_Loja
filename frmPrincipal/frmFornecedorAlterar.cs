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
    public partial class frmFornecedorAlterar : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();

        int id, prazoPagamento;
        string nome, telefone, celular, cidade, tipoProduto;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmFornecedorAlterarFinal f = new frmFornecedorAlterarFinal();
            f.recebeDados(id, nome, telefone, celular, cidade, tipoProduto, prazoPagamento);
            f.ShowDialog();
            f.Dispose();
            this.Close();
        }

        public frmFornecedorAlterar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string buscar = txtNome.Text;

                string query = @"SELECT idFor AS ID, nomeFor AS Nome, telFor AS Telefone, celFor AS Celular, cidadeFor AS Cidade, tipoProdutoFor AS Tipo_Produto, prazoPagamentoFor AS Prazo_Pagamento FROM Fornecedor WHERE nomeFor LIKE '%" + buscar + "%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
            nome = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
            telefone = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
            celular = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
            cidade = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
            tipoProduto = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
            prazoPagamento = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[6].Value);

            btnAlterar.Enabled = true;
        }
    }
}
