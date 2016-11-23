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
    public partial class frmFornecedorConsultar : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();

        public frmFornecedorConsultar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string buscar = txtNome.Text;

                string query = @"SELECT idFor AS ID, nomeFor AS Nome, telFor AS Telefone, celFor AS Celular, cidadeFor AS Cidade, tipoProdutoFor AS Tipo_Produto, prazoPagamentoFor AS Prazo_Pagamento FROM Fornecedor WHERE nomeFor LIKE '%"+buscar+"%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
