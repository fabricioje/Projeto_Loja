﻿namespace frmPrincipal
{
    partial class frmVendaFechadaComPeriodo
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
            this.Venda_Fechada_Com_PeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDataSet = new LojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Venda_Fechada_Com_PeriodoTableAdapter = new LojaDataSetTableAdapters.Venda_Fechada_Com_PeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Fechada_Com_PeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Venda_Fechada_Com_PeriodoBindingSource
            // 
            this.Venda_Fechada_Com_PeriodoBindingSource.DataMember = "Venda_Fechada_Com_Periodo";
            this.Venda_Fechada_Com_PeriodoBindingSource.DataSource = this.LojaDataSet;
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
            reportDataSource1.Name = "RelatorioVendaFechadaComPeriodo";
            reportDataSource1.Value = this.Venda_Fechada_Com_PeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmPrincipal.repVendaFechadaComPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // Venda_Fechada_Com_PeriodoTableAdapter
            // 
            this.Venda_Fechada_Com_PeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendaFechadaComPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 571);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVendaFechadaComPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Vendas Fechadas";
            this.Load += new System.EventHandler(this.frmVendaFechadaComPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Fechada_Com_PeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Venda_Fechada_Com_PeriodoBindingSource;
        private LojaDataSet LojaDataSet;
        private LojaDataSetTableAdapters.Venda_Fechada_Com_PeriodoTableAdapter Venda_Fechada_Com_PeriodoTableAdapter;
    }
}