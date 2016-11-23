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
    public partial class frmVendaProduto : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        frmVenda formularioVenda; //objeto do tipo FORM 1, que será usado dentro da classe

        int idProduto, fornecedor;
        double valorCompra, valorVenda;
        string nomeProduto, tamanho, dataCompra, tipo;

        public frmVendaProduto(frmVenda fVenda) //recebo por parametro um objeto do tipo FORM1
        {
            InitializeComponent();
            con = banco.abrir_conexao();

            formularioVenda = fVenda; //atribuo a instancia recebida pelo construtor a minha variavel interna
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            formularioVenda.recebeDadosProduto(idProduto, nomeProduto, tamanho, valorCompra, valorVenda, dataCompra, tipo, fornecedor);
            this.Close();
        }
        
        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idProduto = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
                nomeProduto = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
                tamanho = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
                valorCompra = Convert.ToDouble(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
                valorVenda = Convert.ToDouble(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
                dataCompra = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
                tipo = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[6].Value);
                fornecedor = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[7].Value);

                btnSelecionar.Enabled = true;
            }catch(Exception)
            {
                MessageBox.Show("Selecione uma opção valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                string seleciona = @"SELECT p.idPro AS ID, p.nomePro AS Nome, p.tamanhoPro AS Tamanho, p.valorCompraPro AS Valor_Compra, p.valorVendaPro AS Valor_Venda, +
                p.dataCompraPro AS Data_Compra, p.tipoPro AS Tipo, f.idFor AS ID_Fornecedor, f.nomeFor AS Fornecedor FROM Produto p INNER JOIN Fornecedor f ON p.idFor = f.idFor WHERE p.nomePro LIKE '%" + nome + "%' OR p.tipoPro LIKE '%" + nome + "%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;

                //esconde a coluna que mostra o valor da compra do produto e o ID do fornecedor
                dataConsulta.Columns[3].Visible = false;
                dataConsulta.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na execução do programa \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
