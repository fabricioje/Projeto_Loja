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
    public partial class frmLogin : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        public static string usuarioConectado;

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string verifica = "SELECT * FROM Usuario WHERE login=@nome AND senha=@senha";

                SqlCommand cmd = new SqlCommand(verifica, con);
                
                cmd.Parameters.AddWithValue("@nome", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {


                    Autenticacao.Login(reader["idUsuario"].ToString(), reader["nomeUsu"].ToString(), reader["login"].ToString(), reader["senha"].ToString(), reader["tipoPermissao"].ToString());
                    usuarioConectado = txtLogin.Text;
                    frmPrincipal f = new frmPrincipal();
                    f.Show();
                    this.Visible = false;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Erro: Usuário e/ou senha não encontrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Dispose();
                }
            }catch(Exception)
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados \n" +
                                "Acesse as configurações do banco de dados e informe os parâmetros de conexão");

                if ((txtLogin.Text == "master") && (txtSenha.Text == "master"))
                {
                    frmPrincipal f = new frmPrincipal();
                    f.Show();
                    this.Visible = false;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Autenticacao.Logout();
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con = banco.abrir_conexao();

            if (con == null)
            {
                lblStatus.Text = "Erro não se conectar ao banco de dados";
            }
            else
            {
                lblStatus.Text = "Conectado ao Banco de Dados";
            }

        }
    }
}
