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
    public partial class frmVendaFechadaSemPeriodo : Form
    {
        public frmVendaFechadaSemPeriodo()
        {
            InitializeComponent();
        }

        private void frmVendaFechadaSemPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaDataSet.Venda_Fechada_Sem_Periodo' table. You can move, or remove it, as needed.
            this.Venda_Fechada_Sem_PeriodoTableAdapter.Fill(this.LojaDataSet.Venda_Fechada_Sem_Periodo);

            this.reportViewer1.RefreshReport();
        }
    }
}
