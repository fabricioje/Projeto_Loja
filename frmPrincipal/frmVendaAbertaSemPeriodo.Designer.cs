namespace frmPrincipal
{
    partial class frmVendaAbertaSemPeriodo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LojaDataSet = new LojaDataSet();
            this.Venda_Aberta_Sem_PeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Venda_Aberta_Sem_PeriodoTableAdapter = new LojaDataSetTableAdapters.Venda_Aberta_Sem_PeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Sem_PeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Venda_Aberta_Sem_PeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmPrincipal.repVendasAbertas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // LojaDataSet
            // 
            this.LojaDataSet.DataSetName = "LojaDataSet";
            this.LojaDataSet.EnforceConstraints = false;
            this.LojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Venda_Aberta_Sem_PeriodoBindingSource
            // 
            this.Venda_Aberta_Sem_PeriodoBindingSource.DataMember = "Venda_Aberta_Sem_Periodo";
            this.Venda_Aberta_Sem_PeriodoBindingSource.DataSource = this.LojaDataSet;
            // 
            // Venda_Aberta_Sem_PeriodoTableAdapter
            // 
            this.Venda_Aberta_Sem_PeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendaAbertaSemPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVendaAbertaSemPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Abertas";
            this.Load += new System.EventHandler(this.frmVendaAbertaSemPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Sem_PeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Venda_Aberta_Sem_PeriodoBindingSource;
        private LojaDataSet LojaDataSet;
        private LojaDataSetTableAdapters.Venda_Aberta_Sem_PeriodoTableAdapter Venda_Aberta_Sem_PeriodoTableAdapter;
    }
}