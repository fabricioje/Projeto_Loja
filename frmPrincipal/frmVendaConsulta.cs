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
    public partial class frmVendaConsulta : Form
    {
        public frmVendaConsulta()
        {
            InitializeComponent();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;


                this.LojaDataSet.Clear();
                this.LojaDataSet.Consulta.Merge(RelatorioController.GetConsulta());

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this,$"Erro:\n\n{ex.Message}",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
