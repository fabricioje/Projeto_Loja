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
    public partial class frmProdutoCadastro : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        int fornecedor;
        public frmProdutoCadastro()
        {
            InitializeComponent();

            Conexao banco = new Conexao();
            con = banco.abrir_conexao();
        }

        private void frmProdutoCadastro_Load(object sender, EventArgs e)
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
        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do valor de venda
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

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);

            //verifica se todos os campos foram preenchidos
            if ((txtNome.Text != "") && (cbTamanho.Text != "") && (txtValorCompra.Text != "") && (txtValorVenda.Text != "") && (txtTipo.Text != "") && (cbFornecedor.Text != "") && (txtQtdComprada.Text != ""))
            {
                string nome = txtNome.Text;
                string tamanho = cbTamanho.Text;
                double valorCompra = Convert.ToDouble(txtValorCompra.Text);
                double valorVenda = Convert.ToDouble(txtValorVenda.Text);
                int qtdCompra = Convert.ToInt32(txtQtdComprada.Text);
                string data = dtpDataCompra.Text;
                string tipo = txtTipo.Text;
                //int fornecedor = Convert.ToInt32(cbFornecedor.ValueMember="idFor");

                try
                {
                    //conexao com o banco de dados *** as duas linhas comentadas a baixo estao em teste
                    //Conexao banco = new Conexao();
                    //SqlConnection con;
                    con = banco.abrir_conexao();

                    int ultimoCodigo = -1;

                    //salvando os dados no banco de dados *** o SELECT no final da instrução é para fazer a leitura dos IDs da tabela
                    string inserir = @"INSERT INTO Produto (nomePro, tamanhoPro, valorCompraPro,valorVendaPro, dataCompraPro, tipoPro, idFor) VALUES ('" + nome + "', '" + tamanho + "','" + valorCompra + "','" + valorVenda + "','" + data + "','" + tipo + "','" + fornecedor + "'); SELECT @@IDENTITY AS ultimo FROM Produto";
                    
                    //execultando o comando SQL
                    SqlCommand cmd = new SqlCommand(inserir, con);

                    //o SqlDataReader é criado para fazer a leitura das IDs na tabela Produto
                    SqlDataReader read = null;

                    //grava os dados na tabela Produto
                    read = cmd.ExecuteReader();

                    //faz a contagem de todos as ID da tabela Produto e para ser inserido na tabela Estoque logo a baixo
                    if (read.HasRows)
                    {
                        read.Read();
                        ultimoCodigo = Convert.ToInt32(read["ultimo"]);
                    }

                    //fecha o read criado para que a possa ser execultado o comando de inserção da tabela Estoque
                    read.Close();

                    //criação da string para fazer a inserção na tabela Estoque
                    string inserir2 = @"INSERT INTO Estoque(quantidadeEst, idPro) VALUES('" + qtdCompra + "', '" + ultimoCodigo + "')";
                    SqlCommand cmd2 = new SqlCommand(inserir2, con);
                    
                    //executa a gravação na tabela Estoque 
                    cmd2.ExecuteNonQuery();

                    //fecha conexao com o banco
                    banco.fecha_conexao();

                    //exibe mensagem de gravado com sucesso
                    MessageBox.Show("Dados salvos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //limpa os campos empreenchidos
                    txtNome.Clear();
                    cbTamanho.Text = "";
                    txtValorCompra.Clear();
                    txtValorVenda.Clear();
                    txtQtdComprada.Clear();
                    txtTipo.Clear();
                    cbFornecedor.Text = "";

                    //deixar o curso no primeiro campo
                    txtNome.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao gravar os dados. \n Erro: " + ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos obrigatórios foram preenchidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTipo.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            cbTamanho.Text = "";

            txtNome.Focus();
        }

        //faz a autenticação do campo
        public static void Moeda(ref TextBox txt)
        {
            //https://www.youtube.com/watch?v=mqwhgCSOTdA
            //http://www.devmedia.com.br/string-format-e-culture-formatando-texto/17706

            string n = string.Empty;
            double v = 0;
            try
            {
                //muda para o tipo de cultura
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

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

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorCompra);
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorVenda);
        }
    }


}

