namespace frmPrincipal
{
    partial class frmVendaFechada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.rbComDataDefinida = new System.Windows.Forms.RadioButton();
            this.rbSemDataDefinida = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.gbDatas);
            this.groupBox1.Controls.Add(this.rbComDataDefinida);
            this.groupBox1.Controls.Add(this.rbSemDataDefinida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição da data";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(624, 44);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(79, 62);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // gbDatas
            // 
            this.gbDatas.Controls.Add(this.label2);
            this.gbDatas.Controls.Add(this.label1);
            this.gbDatas.Controls.Add(this.dtpDataFinal);
            this.gbDatas.Controls.Add(this.dtpDataInicial);
            this.gbDatas.Location = new System.Drawing.Point(327, 19);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Size = new System.Drawing.Size(262, 100);
            this.gbDatas.TabIndex = 2;
            this.gbDatas.TabStop = false;
            this.gbDatas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(133, 63);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(133, 25);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // rbComDataDefinida
            // 
            this.rbComDataDefinida.AutoSize = true;
            this.rbComDataDefinida.Location = new System.Drawing.Point(176, 61);
            this.rbComDataDefinida.Name = "rbComDataDefinida";
            this.rbComDataDefinida.Size = new System.Drawing.Size(110, 17);
            this.rbComDataDefinida.TabIndex = 1;
            this.rbComDataDefinida.TabStop = true;
            this.rbComDataDefinida.Text = "Com data definida";
            this.rbComDataDefinida.UseVisualStyleBackColor = true;
            this.rbComDataDefinida.CheckedChanged += new System.EventHandler(this.rbComDataDefinida_CheckedChanged);
            // 
            // rbSemDataDefinida
            // 
            this.rbSemDataDefinida.AutoSize = true;
            this.rbSemDataDefinida.Location = new System.Drawing.Point(25, 61);
            this.rbSemDataDefinida.Name = "rbSemDataDefinida";
            this.rbSemDataDefinida.Size = new System.Drawing.Size(110, 17);
            this.rbSemDataDefinida.TabIndex = 0;
            this.rbSemDataDefinida.TabStop = true;
            this.rbSemDataDefinida.Text = "Sem data definida";
            this.rbSemDataDefinida.UseVisualStyleBackColor = true;
            // 
            // frmVendaFechada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVendaFechada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Fechadas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatas.ResumeLayout(false);
            this.gbDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.RadioButton rbComDataDefinida;
        private System.Windows.Forms.RadioButton rbSemDataDefinida;
    }
}