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
    public partial class frmVendaRealizada : Form
    {
        

        public frmVendaRealizada()
        {
            InitializeComponent();
        }

        private void rbComDataDefinida_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbComDataDefinida.Checked == true){
                gbDatas.Visible = true;
            }
            else
            {
                gbDatas.Visible = false;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial, dataFinal;

            if (rbSemDataDefinida.Checked == true)
            {
                frmVendaRealizadaSemPeriodo f = new frmVendaRealizadaSemPeriodo();
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                dataInicial = dtpDataInicial.Value;
                dataFinal = dtpDataFinal.Value;

                frmVendaRealizadaComPeriodo f = new frmVendaRealizadaComPeriodo();
                f.getdata(dataInicial, dataFinal);
                f.ShowDialog();
                f.Dispose();
            }
        }
    }
}
