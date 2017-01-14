namespace frmPrincipal
{
    partial class frmVendaFechadaSemPeriodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Venda_Fechada_Sem_PeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDataSet = new LojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Venda_Fechada_Sem_PeriodoTableAdapter = new LojaDataSetTableAdapters.Venda_Fechada_Sem_PeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Fechada_Sem_PeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Venda_Fechada_Sem_PeriodoBindingSource
            // 
            this.Venda_Fechada_Sem_PeriodoBindingSource.DataMember = "Venda_Fechada_Sem_Periodo";
            this.Venda_Fechada_Sem_PeriodoBindingSource.DataSource = this.LojaDataSet;
            // 
            // LojaDataSet
            // 
            this.LojaDataSet.DataSetName = "LojaDataSet";
            this.LojaDataSet.EnforceConstraints = false;
            this.LojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioVendaFechadaSemPeriodo";
            reportDataSource1.Value = this.Venda_Fechada_Sem_PeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmPrincipal.repVendaFechadaSemPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // Venda_Fechada_Sem_PeriodoTableAdapter
            // 
            this.Venda_Fechada_Sem_PeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendaFechadaSemPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVendaFechadaSemPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Fechadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendaFechadaSemPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Fechada_Sem_PeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Venda_Fechada_Sem_PeriodoBindingSource;
        private LojaDataSet LojaDataSet;
        private LojaDataSetTableAdapters.Venda_Fechada_Sem_PeriodoTableAdapter Venda_Fechada_Sem_PeriodoTableAdapter;
    }
}