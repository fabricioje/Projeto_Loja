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
    public partial class frmVendaRecebimento : Form
    {

        SqlConnection con;
        Conexao banco = new Conexao();

        int id, quantidadeparcelas, parcelasRestantes;
        double valorTotal, valorParcela;
        string nome, cpf, dataNascimento, situacao;
        DateTime dataVencimento;

        private void btnReceber_Click(object sender, EventArgs e)
        {
            DateTime dataVencimentoAtualizada = ConverteData(dataVencimento);
            

            VerificaParcela v = new VerificaParcela();
            int parcelaAtualizada = v.BaixaParcela(parcelasRestantes);
            string situacaoAtualizada = v.VerificaSituacao(parcelaAtualizada);

            string query = @"UPDATE Venda SET dataVencimento = '"+ dataVencimentoAtualizada +"', parcelasRestantes = '" + parcelaAtualizada + "', situacaoVenda = '" + situacaoAtualizada + "' WHERE idVen = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
                       
            double valorRecebido = Convert.ToDouble(txtValorRecebido.Text);

            MessageBox.Show("Pagamento efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            if (valorRecebido > valorParcela)
            {
                MessageBox.Show("O valor do troco é: R$ " + (valorRecebido - valorParcela));
            }

            //limpa os dados
            txtNome.Clear();
            txtParcelaAtual.Clear();
            txtQtdParcelas.Clear();
            txtValorParcela.Clear();
            txtValorRecebido.Clear();
            txtValorTotal.Clear();
            dataConsulta.Columns.Clear();
            txtNome.Focus();
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            double valorPago = Convert.ToDouble(txtValorRecebido.Text);
            if (valorPago < valorParcela)
            {
                txtValorRecebido.Focus();
                MessageBox.Show("O valor recebido não pode ser menor que o valor da venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReceber.Enabled = false;
            }
            else
            {
                btnReceber.Enabled = true;
            }
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorRecebido);

            double valorPago = Convert.ToDouble(txtValorRecebido.Text);
            if (valorPago < valorParcela)
            {
                btnReceber.Enabled = false;
            }
            else
            {
                btnReceber.Enabled = true;
            }
        }

       

        public frmVendaRecebimento()
        {
            InitializeComponent();

            btnReceber.Enabled = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string nome=txtNome.Text;

            try
            {
                con = banco.abrir_conexao();

                string query = @"SELECT Venda.idVen, Cliente.nomeCli AS Nome, Cliente.cpfCli AS CPF, Cliente.dataNascimentoCli AS Data_Nascimento, Venda.dataVencimento AS Data_Vencimento, Venda.valorTotal AS Valor_Total, Venda.qtdParcelas AS Qtd_Parcelas, Venda.parcelasRestantes AS Parcelas_Restantes, Venda.situacaoVenda AS Situacao FROM Cliente INNER JOIN Venda ON Cliente.idCli = Venda.idCli WHERE (Cliente.nomeCli LIKE '%" + nome + "%' AND Venda.situacaoVenda = 'ABERTA') OR (Cliente.cpfCli LIKE '%" + nome + "' AND Venda.situacaoVenda = 'ABERTA') ";
                            
                SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;

                //oculta a coluna ID
                dataConsulta.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VerificaParcela v = new VerificaParcela();

            try
            {
                id = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
                cpf = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
                dataNascimento = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
                dataVencimento = Convert.ToDateTime(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
                valorTotal = Convert.ToDouble(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
                quantidadeparcelas = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[6].Value);
                parcelasRestantes = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[7].Value);
                situacao = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[8].Value);

                txtValorTotal.Text = Convert.ToString(valorTotal);
                txtQtdParcelas.Text = Convert.ToString(quantidadeparcelas);
                txtParcelaAtual.Text = Convert.ToString(v.VerificaParcelas(quantidadeparcelas, parcelasRestantes));
                valorParcela = v.VerificaValorParcela(valorTotal, quantidadeparcelas);
                txtValorParcela.Text = String.Format("{0:N}", valorParcela);
            }
            catch (Exception)
            {

            }
            
        }
        
        public DateTime ConverteData(DateTime data)
        {
            //acrescenta mais um mes
            data = data.AddMonths(1);
            return data;
        }
    

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
    }
}
