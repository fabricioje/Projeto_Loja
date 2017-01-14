using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmVendaAberta : Form
    {
        public frmVendaAberta()
        {
            InitializeComponent();

        }

        private void rbDataDefinida_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if(rbn.Checked == true)
            {
                dtpData.Visible = true;
            }
            else
            {
                dtpData.Visible = false;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DateTime periodo = dtpData.Value;
            DateTime dataAtual = DateTime.Now;


            if (rbDataIndefinida.Checked == true)
            {
                //chama relatório sem data pré definida
                frmVendaAbertaSemPeriodo f = new frmVendaAbertaSemPeriodo();
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                //chama o relatório dom data definada pelo usuário
                frmVendaAbertaComPeriodo f = new frmVendaAbertaComPeriodo();
                f.getData(dataAtual, periodo);
                f.ShowDialog();
                f.Dispose();

                
            }

        }
    }
}
