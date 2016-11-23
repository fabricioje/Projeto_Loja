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
    public partial class frmClienteConsultar : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;

        public frmClienteConsultar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void frmClienteConsultar_Load(object sender, EventArgs e)
        {
            try
            {
                string seleciona = @"SELECT idCli AS ID, nomeCli AS Nome, maeCli AS Nome_da_Mãe,cpfCli AS CPF, dataNascimentoCli AS Data_Nascimento, cidadeCli AS Cidade, ruaCli AS Rua, numeroCli AS Número, bairroCli AS Bairro, referenciaCli AS Referencia, telCli AS Telefone, celCli AS Celular, limiteCreditoCli AS Limite_de_Credito FROM Cliente";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string buscar = txtNome.Text; 

                string seleciona = @"SELECT idCli AS ID, nomeCli AS Nome, maeCli AS Nome_da_Mãe,cpfCli AS CPF, dataNascimentoCli AS Data_Nascimento, ruaCli AS Rua, numeroCli AS Número, bairroCli AS Bairro, referenciaCli AS Referencia, telCli AS Telefone, celCli AS Celular, limiteCreditoCli AS Limite_de_Credito FROM Cliente WHERE nomeCli LIKE '%"+ buscar +"%' OR cpfCli LIKE '%"+ buscar +"%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
