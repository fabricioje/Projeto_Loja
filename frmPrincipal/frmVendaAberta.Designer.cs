namespace frmPrincipal
{
    partial class frmVendaAberta
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
            this.LojaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.rbDataDefinida = new System.Windows.Forms.RadioButton();
            this.rbDataIndefinida = new System.Windows.Forms.RadioButton();
            this.LojaDataSet = new LojaDataSet();
            this.Venda_Aberta_Sem_PeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Venda_Aberta_Sem_PeriodoTableAdapter = new LojaDataSetTableAdapters.Venda_Aberta_Sem_PeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Sem_PeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LojaDataSetBindingSource
            // 
            this.LojaDataSetBindingSource.DataMember = "Venda_Aberta_Com_Periodo";
            this.LojaDataSetBindingSource.DataSource = typeof(LojaDataSet);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.rbDataDefinida);
            this.groupBox1.Controls.Add(this.rbDataIndefinida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição do período";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(574, 28);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(391, 30);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 2;
            this.dtpData.Visible = false;
            // 
            // rbDataDefinida
            // 
            this.rbDataDefinida.AutoSize = true;
            this.rbDataDefinida.Location = new System.Drawing.Point(241, 34);
            this.rbDataDefinida.Name = "rbDataDefinida";
            this.rbDataDefinida.Size = new System.Drawing.Size(88, 17);
            this.rbDataDefinida.TabIndex = 1;
            this.rbDataDefinida.TabStop = true;
            this.rbDataDefinida.Text = "Data definida";
            this.rbDataDefinida.UseVisualStyleBackColor = true;
            this.rbDataDefinida.CheckedChanged += new System.EventHandler(this.rbDataDefinida_CheckedChanged);
            // 
            // rbDataIndefinida
            // 
            this.rbDataIndefinida.AutoSize = true;
            this.rbDataIndefinida.Location = new System.Drawing.Point(60, 34);
            this.rbDataIndefinida.Name = "rbDataIndefinida";
            this.rbDataIndefinida.Size = new System.Drawing.Size(96, 17);
            this.rbDataIndefinida.TabIndex = 0;
            this.rbDataIndefinida.TabStop = true;
            this.rbDataIndefinida.Text = "Data indefinida";
            this.rbDataIndefinida.UseVisualStyleBackColor = true;
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
            // frmVendasAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVendasAbertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas em Aberto";
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venda_Aberta_Sem_PeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton rbDataDefinida;
        private System.Windows.Forms.RadioButton rbDataIndefinida;
        private System.Windows.Forms.BindingSource LojaDataSetBindingSource;
        private System.Windows.Forms.BindingSource Venda_Aberta_Sem_PeriodoBindingSource;
        private LojaDataSet LojaDataSet;
        private LojaDataSetTableAdapters.Venda_Aberta_Sem_PeriodoTableAdapter Venda_Aberta_Sem_PeriodoTableAdapter;
    }
}