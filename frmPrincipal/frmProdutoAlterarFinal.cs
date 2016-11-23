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
using System.Globalization;
using System.Threading;

namespace frmPrincipal
{
    public partial class frmProdutoAlterarFinal : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;

        int idPro;
        public frmProdutoAlterarFinal()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void frmProdutoAlterarFinal_Load(object sender, EventArgs e)
        {
            string selectIDTalhao = "SELECT * FROM Fornecedor";

            SqlDataAdapter adapter = new SqlDataAdapter(selectIDTalhao, con);
            DataTable table = new DataTable();

            adapter.Fill(table);
            adapter.Dispose();

            cbFornecedor.DataSource = table;
            cbFornecedor.DisplayMember = "nomeFor";
            cbFornecedor.ValueMember = "idFor";

        }

        public void recebeDados(int recebeIdPro, string recebeNome, string recebeTamanho, double recebeValorCompra, double recebeValorVenda, string recebeData, string recebeTipo, int recebeIdFor)
        {
            idPro = recebeIdPro;
            txtNome.Text = recebeNome;
            cbTamanho.Text = recebeTamanho;
            txtValorCompra.Text = Convert.ToString(recebeValorCompra);
            txtValorVenda.Text = Convert.ToString(recebeValorVenda);
            dtpDataCompra.Text = recebeData;
            txtTipo.Text = recebeTipo;
            cbFornecedor.SelectedItem = recebeIdFor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            string nome = txtNome.Text;
            string tamanho = cbTamanho.Text;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorVenda = Convert.ToDouble(txtValorVenda.Text);
            string data = dtpDataCompra.Text;
            string tipo = txtTipo.Text;
            int idFor = Convert.ToInt32(cbFornecedor.SelectedValue);

            try
            {
                string atualiza = @"UPDATE Produto SET nomePro = '" + nome + "', tamanhoPro = '" + tamanho + "', valorCompraPro = '" + valorCompra + "', valorVendaPro = '" + valorVenda + "', dataCompraPro = '" + data + "', tipoPro = '" + tipo + "', idFor = '" + idFor + "' WHERE idPro = '" + idPro + "' ";
                SqlCommand cmd = new SqlCommand(atualiza, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Atualização realizada com sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na execução do programa. \n Erro: " + ex.Message);
            }
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorCompra.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
/**
       private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorCompra);
        }    

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorVenda);
        }
            **/
        

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorCompra.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
/**
        public static void Moeda(ref TextBox txt)
        {
            //https://www.youtube.com/watch?v=mqwhgCSOTdA
            //http://www.devmedia.com.br/string-format-e-culture-formatando-texto/17706

            string n = string.Empty;
            double v = 0;
            try
            {
                //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }
        }
    **/

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

       
    }
}
