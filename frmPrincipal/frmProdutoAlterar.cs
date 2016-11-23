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
    public partial class frmProdutoAlterar : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;

        int idPro, idFor;
        double valorCompra, valorVenda;
        string nome, tamanho, data, tipo;

        public frmProdutoAlterar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();

            btnAlterar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmProdutoAlterarFinal p = new frmProdutoAlterarFinal();
            p.recebeDados(idPro, nome, tamanho, valorCompra, valorVenda, GETdata(), tipo, idFor);
            p.ShowDialog();
            this.Close();
        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idPro = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
                tamanho = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
                valorCompra = Convert.ToDouble(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
                valorVenda = Convert.ToDouble(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
                data = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
                tipo = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[6].Value);
                idFor = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[7].Value);

                btnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na execução do programa \n\r Erro:" + ex.Message, "Erro ", MessageBoxButtons.OK);
            }
        }
        
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                string seleciona = @"SELECT p.idPro AS ID, p.nomePro AS Nome, p.tamanhoPro AS Tamanho, p.valorCompraPro AS Valor_Compra, p.valorVendaPro AS Valor_Venda, +
                p.dataCompraPro AS Data_Compra, p.tipoPro AS Tipo, f.idFor AS ID_Fornecedor, f.nomeFor AS Fornecedor FROM Produto p INNER JOIN Fornecedor f ON p.idFor = f.idFor WHERE p.nomePro LIKE '%"+ nome +"%' OR p.tipoPro LIKE '%"+ nome +"%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na execução do programa \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
            
        }

        public string GETdata()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            string convertData = data;
            return convertData.ToString();
        }

    }
}
