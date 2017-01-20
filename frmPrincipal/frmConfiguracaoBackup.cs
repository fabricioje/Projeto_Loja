using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmConfiguracaoBackup : Form
    {
        public frmConfiguracaoBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBancoDados.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();

                MessageBox.Show("Arquivo atualizado com sucesso!!!");
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void frmConfiguracaoBackup_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBancoDados.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            

        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                //DadosBanco dados = new DadosBanco();
                Conexao.servidor = txtServidor.Text;
                Conexao.banco = txtBancoDados.Text;
                Conexao.usuario = txtUsuario.Text;
                Conexao.senha = txtSenha.Text;
                //testar conexao
                SqlConnection c = new SqlConnection();
                c.ConnectionString = Conexao.testar_conexao;
                c.Open();
                c.Close();

                MessageBox.Show("Conexão efetuada com sucesso");

            }catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados \n" +
                                "Verifique os dados informados");
            }
        }
    }
}
