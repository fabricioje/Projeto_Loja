namespace frmPrincipal
{
    partial class frmVendaConsulta
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
            this.ConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.LojaDataSet = new frmPrincipal.LojaDataSet();
            this.LojaDataSet = new LojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaBindingSource
            // 
            this.ConsultaBindingSource.DataMember = "Consulta";
            this.ConsultaBindingSource.DataSource = this.LojaDataSet;
            // 
            // LojaDataSet
            // 
            this.LojaDataSet.DataSetName = "LojaDataSet";
            this.LojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsConsulta";
            reportDataSource1.Value = this.ConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmPrincipal.Relatorio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Venda";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsultaBindingSource;
        public LojaDataSet LojaDataSet;
    }
}