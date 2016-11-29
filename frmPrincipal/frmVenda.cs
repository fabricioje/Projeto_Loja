using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmVenda : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();

        string nomeCliente, nomeMae, cpf, dataNascimento, cidade, rua, bairro, referencia, telefone, celular;
        string nomeProduto, tamanho, dataCompra, tipo, dataVencimento=null, formaPagamento,coluna2;
        int idCliente, idProduto, idVenda, numero, fornecedor, quantidadeParcela, quantidadeProduto, coluna1, coluna3;
        double limiteCredito, valorCompra, valorVenda, valorSomaProduto, totalDaVenda, totalDaVendaComDesconto, totalDaVendaFinal, desconto, valorPago, coluna4, coluna5;

        public frmVenda()
        {
            InitializeComponent();

            con = banco.abrir_conexao();

            //desabilita o groupBox e o botão para incluir produtos na lista
            gpbVenda.Enabled = false;
            btnIncluir.Enabled = false;
        }

        private void btnExluirItem_Click(object sender, EventArgs e)
        {
            //remove item da datagrid
            string valorTabela = dataConsulta.CurrentRow.Cells[4].Value.ToString();
            //pega o valor do valor total
            double valor = Convert.ToDouble(valorTabela);
            //faz a subtração do valor e atualiza o valor total
            totalDaVenda = totalDaVenda - valor;
            txtValorTotal.Text = totalDaVenda.ToString();
            dataConsulta.Rows.Remove(dataConsulta.CurrentRow);
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            //recebe o valor do textbox atualizado para fazer a verificação
            valorPago = Convert.ToDouble(txtValorPago.Text.Replace("R$",""));            
            double valorAtualizado = Convert.ToDouble(txtValorTotal.Text);

            if (valorPago < valorAtualizado)
            {
                txtValorPago.Text = "";
                txtValorPago.Focus();
                MessageBox.Show("O valor recebido não pode ser menor que o valor da venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //habilita o botão de finalizar venda, após a escolha de uma opção
            if (cbFormaPagamento.Text != "")
            {
                btnFinalizar.Enabled = true;
            }

            //verifica a forma de pagamento, sendo a prazo habiliza o dateTimePicker para escolher a data de vencimento
            if (cbFormaPagamento.Text == "A PRAZO")
            {
                dtpPrazoVenda.Enabled = true;
                cbQtdParcelas.Enabled = true;
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            gpbPagamento.Enabled = true;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDesconto);


            //faz o calculo do desconto em tempo real
            if (txtDesconto.Text != "")
            {
                desconto = Convert.ToDouble(txtDesconto.Text);
                totalDaVendaComDesconto = totalDaVenda - desconto;
                txtValorTotal.Text = Convert.ToString(totalDaVendaComDesconto);
            }

            //verificar se o valor do desconto não foi maior que o valor total da compra
            if(totalDaVendaComDesconto <= 0)
            {                
                totalDaVendaComDesconto = totalDaVenda;
                txtValorTotal.Text = Convert.ToString(totalDaVenda);
                txtDesconto.Text = "";
                totalDaVendaComDesconto = 0;
                MessageBox.Show("O valor do desconto não pode ser maior ou igual ao valor da compra\n  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorPago);

        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtDesconto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }

        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo, não deixa digitar letras
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
        
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //habilita o botão para finalizar o Pedido
            btnFinalizarPedido.Enabled = true;

            //pega o valor do numericUpDown, converte para int e faz a multiplicação do valor da quantidade de produtos colocado na lista
            quantidadeProduto = (int)numericQuantidade.Value;
            valorSomaProduto = valorVenda * quantidadeProduto;

            //soma o total de cada produto adicionado na lista
            totalDaVenda += valorSomaProduto;

            // array de string com os dados informados para serem exibidos no dataGridView
            string[] dados = { txtCodProduto.Text, nomeProduto, numericQuantidade.Text, txtValorProduto.Text, Convert.ToString(valorSomaProduto) };

            // coluna do datagridview
            dataConsulta.ColumnCount = 5;
            dataConsulta.Columns[0].Name = "Código do Produto";
            dataConsulta.Columns[1].Name = "Nome do Produto";
            dataConsulta.Columns[2].Name = "Quantidade";
            dataConsulta.Columns[3].Name = "Valor do Produto";
            dataConsulta.Columns[4].Name = "Valor Total";

            //tamanho das colunas
            dataConsulta.Columns[0].Width = 100;
            dataConsulta.Columns[1].Width = 200;
            dataConsulta.Columns[2].Width = 120;
            dataConsulta.Columns[3].Width = 120;
            dataConsulta.Columns[4].Width = 120;


            // preenche o datagridview com os dados informados
            // cada possição do array de string corresponde a uma
            // coluna do datagridview
            this.dataConsulta.Rows.Add(dados);

            //limpa os campos
            txtCodProduto.Clear();
            numericQuantidade.Value = 1;
            txtValorProduto.Clear();

            //desabilita o botão de incluir
            btnIncluir.Enabled = false;

            //atualiza o valor total da compra
            txtValorTotal.Text = Convert.ToString(totalDaVenda);

        }

        public void recebeDadosCliente(int recebeID, string recebeNome, string recebeMae, string recebeCPF, string recebeNascimento, string recebeRua, int recebeNumero, string recebeBairro, string recebeCidade, string recebeReferencia, string recebeTelefone, string recebeCelular, double recebeLimite)
        {
            idCliente = recebeID;
            nomeCliente = recebeNome;
            nomeMae = recebeMae;
            cpf = recebeCPF;
            dataNascimento = recebeNascimento;
            rua = recebeRua;
            numero = recebeNumero;
            bairro = recebeBairro;
            cidade = recebeCidade;
            referencia = recebeReferencia;
            telefone = recebeTelefone;
            celular = recebeCelular;
            limiteCredito = recebeLimite;
        }

        public void recebeDadosProduto(int recebeID, string recebeNome, string recebeTamanho, double recebeValorCompra, double recebeValorVenda, string recebeDataCompra, string recebeTipo, int recebeFornecedor)
        {
            idProduto = recebeID;
            nomeProduto = recebeNome;
            tamanho = recebeTamanho;
            valorCompra = recebeValorCompra;
            valorVenda = recebeValorVenda;
            dataCompra = recebeDataCompra;
            tipo = recebeTipo;
            fornecedor = recebeFornecedor;
        }
        
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string dataDaVenda = data();
            int ultimoCodigo = -1;
            formaPagamento = cbFormaPagamento.Text;
            quantidadeParcela = Convert.ToInt32(cbQtdParcelas.SelectedItem);
            dataVencimento = dtpPrazoVenda.Text;

            //verificar se teve desconto ou não
            if(totalDaVendaComDesconto > 0)
            {
                totalDaVendaFinal = totalDaVendaComDesconto;
            }
            else
            {
                totalDaVendaFinal = totalDaVenda;
            }

            try
            {
                //salvando os dados no banco de dados *** o SELECT no final da instrução é para fazer a leitura dos IDs da tabela
                string query = @"INSERT INTO Venda (idCli, idUsu, idPro, dataVenda, dataVencimento, formaPagVen, valorTotal, qtdParcelas) Values ('" + idCliente + "','" + Autenticacao.getID() + "','" + idProduto + "','" + dataDaVenda + "','" + dataVencimento + "','" + formaPagamento + "','" + converteValorVenda() + "','" + quantidadeParcela + "'); SELECT @@IDENTITY AS ultimo FROM Venda";

                //execultando o comando SQL
                SqlCommand cmd = new SqlCommand(query, con);

                //o SqlDataReader é criado para fazer a leitura das IDs na tabela Produto
                SqlDataReader read = null;

                //grava os dados na tabela Venda
                read = cmd.ExecuteReader();

                //faz a contagem de todos as ID da tabela Produto e para ser inserido na tabela Estoque logo a baixo
                if (read.HasRows)
                {
                    read.Read();
                    ultimoCodigo = Convert.ToInt32(read["ultimo"]);
                }

                //fecha o read criado para que a possa ser execultado o comando de inserção da tabela Item_Venda
                read.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salva a venda no banco de dados\n " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //salva dos dados do DataGridView, salva cada coluna em uma variavel e passa por toda a lista salvando cada linha
                for (int i = 0; i <= dataConsulta.Rows.Count - 1; i++)
                {
                    //Foi necessário muldar a cultura pois ao pegar os dados do datagrid os mesmos estavam vindo sem a virgula
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

                    coluna1 = Convert.ToInt32(dataConsulta.Rows[i].Cells[0].Value); //código do produto
                    coluna2 = Convert.ToString(dataConsulta.Rows[i].Cells[1].Value); //nome do produto
                    coluna3 = Convert.ToInt32(dataConsulta.Rows[i].Cells[2].Value); //quantidade do produto
                    coluna4 = Convert.ToDouble(dataConsulta.Rows[i].Cells[3].Value); //valor do produto
                    coluna5 = Convert.ToDouble(dataConsulta.Rows[i].Cells[4].Value); //valor total da compra

                    string query2 = @"INSERT INTO Item_Venda(idVen, idPro, quantidade, valorUnidade, valorTotal) VALUES ('" + ultimoCodigo + "','" + coluna1 + "','" + coluna3 + "','" + converteItemValorProduto() + "','" + converteItemValorTotalItem() + "')";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();         
                }

                MessageBox.Show("Venda realizada com sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();

                //verificar se tem troco no valor pago
                if (valorPago > totalDaVendaFinal)
                {
                    double troco = valorPago - totalDaVendaFinal;
                    MessageBox.Show("O valor do troco é: R$" + troco, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                }
            }
            catch(Exception ex2)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o item da venda no banco de dados\n " + ex2, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmVendaCliente f = new frmVendaCliente(this);
            f.ShowDialog();
            txtNome.Text = nomeCliente;

            //faz a leitura de todas a linhas da tabela vendas
            if (txtNome.Text != "")
            {
                gpbVenda.Enabled = true;

                string query = @"SELECT COUNT (*) FROM Venda";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader read = cmd.ExecuteReader();

                int cont = 0;
                while (read.Read())
                {
                    cont = cont + 1;
                }
                cont = cont - 1;
                txtCodVenda.Text = cont.ToString();
                read.Close();

                //armazena o id da tabela Venda para salvar na tabela Item_Venda
                idVenda = cont;
            }
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            frmVendaProduto f = new frmVendaProduto(this);
            f.ShowDialog();

            txtCodProduto.Text = Convert.ToString(idProduto);
            txtValorProduto.Text = Convert.ToString(valorVenda);

            //habilita o botao para incluir produto na lista
            btnIncluir.Enabled = true;

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
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

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
    
        //Método para mudar a cultura da data para ser salva no banco de dados
        public string data()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            DateTime getDate = DateTime.Now;
            return getDate.ToString();
        }
        
        //Método para mudar a cultura da variável tipo double para ser salva no banco de dados
        public double converteValorVenda()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double valorConvertido;
            double getvalor = totalDaVendaFinal;
            valorConvertido = getvalor;
            return valorConvertido;
        }

        //Método para mudar a cultura da variável tipo double para ser salva no banco de dados
        public double converteItemValorProduto()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double valorConvertido;
            double getvalor = totalDaVendaFinal;
            valorConvertido = getvalor;
            return valorConvertido;
        }

        //Método para mudar a cultura da variável tipo double para ser salva no banco de dados
        public double converteItemValorTotalItem()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double valorConvertido;
            double getvalor = totalDaVendaFinal;
            valorConvertido = getvalor;
            return valorConvertido;
        }

    }
}
