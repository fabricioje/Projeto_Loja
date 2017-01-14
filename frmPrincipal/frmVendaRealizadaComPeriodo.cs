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
    public partial class frmVendaRealizadaComPeriodo : Form
    {
        DateTime dataInicial, dataFinal;

        public frmVendaRealizadaComPeriodo()
        {
            InitializeComponent();
        }

        public void getdata(DateTime getDataInicial, DateTime getDataFinal)
        {
            dataInicial = getDataInicial;
            dataFinal = getDataFinal;
        }

        private void frmVendaRealizadaComPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaDataSet.Venda_Realizada_Com_Periodo' table. You can move, or remove it, as needed.
            this.Venda_Realizada_Com_PeriodoTableAdapter.Fill(this.LojaDataSet.Venda_Realizada_Com_Periodo,dataInicial, dataFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
