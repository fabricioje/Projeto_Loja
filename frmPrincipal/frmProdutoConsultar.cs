using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmProdutoConsultar : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;

        public frmProdutoConsultar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text; ;
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

                string seleciona = @"SELECT p.idPro AS ID, p.nomePro AS Nome, p.tamanhoPro AS Tamanho, p.valorCompraPro AS Valor_Compra, p.valorVendaPro AS Valor_Venda, +
                p.dataCompraPro AS Data_Compra, p.tipoPro AS Tipo, f.nomeFor AS Fornecedor FROM Produto p INNER JOIN Fornecedor f ON p.idFor = f.idFor WHERE p.nomePro LIKE '%"+ nome +"%' OR p.tipoPro LIKE '%"+ nome +"%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;

            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na execução do programa \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
            
        }
    }
}
