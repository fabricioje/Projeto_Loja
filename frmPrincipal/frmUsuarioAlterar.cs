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
    public partial class frmUsuarioAlterar : Form
    {
        SqlConnection con;
        Conexao banco = new Conexao();

        int id, numero;
        string nome, data, cidade, rua, bairro, telefone, celular, login, senha, permissao;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmUsuarioAlterarFinal f = new frmUsuarioAlterarFinal();
            f.recebeDados(id, nome, data, cidade, rua, numero, bairro, telefone, celular, login, senha, permissao);
            f.ShowDialog();
            f.Dispose();
            this.Close();
        }

        public frmUsuarioAlterar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnAlterar.Enabled = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
                data = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
                cidade = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
                rua = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
                numero = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
                bairro = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[6].Value);
                telefone = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[7].Value);
                celular = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[8].Value);
                login = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[9].Value);
                senha = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[10].Value);
                permissao = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[11].Value);

                btnAlterar.Enabled = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na execução do programa \n\r Erro:" + ex.Message, "Erro ", MessageBoxButtons.OK);
            }
            
        }
    }
}
