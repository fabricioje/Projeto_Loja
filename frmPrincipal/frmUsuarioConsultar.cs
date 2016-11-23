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
    
    public partial class frmUsuarioConsultar : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;
        public frmUsuarioConsultar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;

                string seleciona = @"SELECT idUsuario AS ID, nomeUsu AS Nome, nascimentoUsu AS Data_Nascimento, cidadeUsu AS Cidade, ruaUsu AS Rua, numeroUsu AS Numero, bairroUsu AS Bairro, telUsu AS Telefone, celUsu AS Celular, login AS Login, senha AS Senha, tipoPermissao AS Tipo_Permissao FROM Usuario WHERE idUsuario LIKE '%" + nome + "%' OR nomeUsu LIKE '%" + nome + "%' ";

                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;

                dataConsulta.Columns[10].Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
            

        }
    }
}
