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
            con = banco.abrir_conexao();

            if (con != null)
            {
                lblStatus.Text = "Conectado ao Banco de Dados";
            }else{
                lblStatus.Text = "Erro não se conectar ao banco de dados";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string verifica = "SELECT * FROM Usuario WHERE login=@nome AND senha=@senha";

            SqlCommand cmd = new SqlCommand(verifica, con);
            
            cmd.Parameters.AddWithValue("@nome", txtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Autenticacao.Login(reader["idUsuario"].ToString(), reader["nomeUsu"].ToString(),reader["login"].ToString(), reader["senha"].ToString(), reader["tipoPermissao"].ToString());
                usuarioConectado = txtLogin.Text;
                frmPrincipal f = new frmPrincipal();        
                f.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Erro: Usuário e/ou senha não encontrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Dispose();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Autenticacao.Logout();
            this.Close();
        }
    }
}
