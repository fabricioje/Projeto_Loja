﻿namespace frmPrincipal
{
    partial class frmVendaAbertaComPeriodo
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
            this.Venda_Aberta_Com_PeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDataSet = new LojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Venda_Aberta_Com_PeriodoTableAdapter = new LojaDataSetTableAdapters.Venda_Aberta_Com_PeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Com_PeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Venda_Aberta_Com_PeriodoBindingSource
            // 
            this.Venda_Aberta_Com_PeriodoBindingSource.DataMember = "Venda_Aberta_Com_Periodo";
            this.Venda_Aberta_Com_PeriodoBindingSource.DataSource = this.LojaDataSet;
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
            reportDataSource1.Name = "DataSetVendaComPeriodo";
            reportDataSource1.Value = this.Venda_Aberta_Com_PeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmPrincipal.repVendaAbertaComPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // Venda_Aberta_Com_PeriodoTableAdapter
            // 
            this.Venda_Aberta_Com_PeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendaAbertaComPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVendaAbertaComPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Abertas com Período";
            this.Load += new System.EventHandler(this.frmVendaAbertaComPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Com_PeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Venda_Aberta_Com_PeriodoBindingSource;
        private LojaDataSet LojaDataSet;
        private LojaDataSetTableAdapters.Venda_Aberta_Com_PeriodoTableAdapter Venda_Aberta_Com_PeriodoTableAdapter;
    }
}