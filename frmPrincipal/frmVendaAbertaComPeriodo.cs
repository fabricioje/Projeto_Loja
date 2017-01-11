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
    public partial class frmVendaAbertaComPeriodo : Form
    {
        DateTime dataAtual, periodo;

        public frmVendaAbertaComPeriodo()
        {
            InitializeComponent();
        }

        public void getData(DateTime getDataAtual, DateTime getPeriodo)
        {
            dataAtual = getDataAtual;
            periodo = getPeriodo;
        }

        private void frmVendaAbertaComPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaDataSet.Venda_Aberta_Com_Periodo' table. You can move, or remove it, as needed.
            this.Venda_Aberta_Com_PeriodoTableAdapter.Fill(this.LojaDataSet.Venda_Aberta_Com_Periodo, dataAtual, periodo);

            this.reportViewer1.RefreshReport();
        }
    }
}
