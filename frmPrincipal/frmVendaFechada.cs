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
    public partial class frmVendaFechada : Form
    {
        DateTime dataInicial, dataFinal;

        public frmVendaFechada()
        {
            InitializeComponent();
        }

        private void rbComDataDefinida_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbn.Checked == true)
            {
                gbDatas.Visible = true;
            }
            else
            {
                gbDatas.Visible = false;
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            dataInicial = dtpDataInicial.Value;
            dataFinal = dtpDataFinal.Value;

            if(rbSemDataDefinida.Checked == true)
            {
                //chama o relatório sem data definida
                frmVendaFechadaSemPeriodo f = new frmVendaFechadaSemPeriodo();
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                //chama relatorio com data definida
                frmVendaFechadaComPeriodo f = new frmVendaFechadaComPeriodo();
                f.getData(dataInicial, dataFinal);
                f.ShowDialog();
                f.Dispose();
            }

            
        }
    }
}
