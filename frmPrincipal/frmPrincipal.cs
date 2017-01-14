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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblUsuarioConectado.Text = "Bem Vindo " + Autenticacao.getUsuario(); ;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteCadastro f = new frmClienteCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteAlterar f = new frmClienteAlterar();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteConsultar f = new frmClienteConsultar();
            f.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro f = new frmProdutoCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoConsultar f = new frmProdutoConsultar();
            f.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoAlterar f = new frmProdutoAlterar();
            f.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastrar f = new frmUsuarioCadastrar();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuarioConsultar f = new frmUsuarioConsultar();
            f.ShowDialog();
            f.Dispose();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuarioAlterar f = new frmUsuarioAlterar();
            f.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void efetuarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda f = new frmVenda();
            f.ShowDialog();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmVendaConsulta f = new frmVendaConsulta();
            f.ShowDialog();
                 
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastro f = new frmFornecedorCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmFornecedorConsultar f = new frmFornecedorConsultar();
            f.ShowDialog();
            f.Dispose();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFornecedorAlterar f = new frmFornecedorAlterar();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaRecebimento f = new frmVendaRecebimento();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendasEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaAberta f = new frmVendaAberta();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendasAPrazoPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaFechada f = new frmVendaFechada();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
