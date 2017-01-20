using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace frmPrincipal
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog abre uma caixa para o usuário escolher onde quer salvar os dados
                SaveFileDialog d = new SaveFileDialog();
                //Filter criar um filtro para o SaveFileDialog
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    DadosBanco dados = new DadosBanco();
                    dados.VerificaDados();
                    String nomeBanco = dados.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + dados.servidor + ";Initial Catalog=master;User=" + dados.usuario + ";Password=" + dados.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup realizado com sucesso!!!");
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialog abre uma caixa para o usuário escolher onde quer salvar os dados
                OpenFileDialog d = new OpenFileDialog();
                //Filter criar um filtro para o OpenFileDialog
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    DadosBanco dados = new DadosBanco();
                    String nomeBanco = dados.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + dados.servidor + ";Initial Catalog=master;User=" + dados.usuario + ";Password=" + dados.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup restaurado com sucesso!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
