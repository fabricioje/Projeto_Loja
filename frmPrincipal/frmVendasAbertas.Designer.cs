namespace frmPrincipal
{
    partial class frmVendasAbertas
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
            this.rbDataIdefinida = new System.Windows.Forms.RadioButton();
            this.rbDataDefinida = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.rbDataDefinida);
            this.groupBox1.Controls.Add(this.rbDataIdefinida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição do período";
            // 
            // rbDataIdefinida
            // 
            this.rbDataIdefinida.AutoSize = true;
            this.rbDataIdefinida.Location = new System.Drawing.Point(60, 34);
            this.rbDataIdefinida.Name = "rbDataIdefinida";
            this.rbDataIdefinida.Size = new System.Drawing.Size(96, 17);
            this.rbDataIdefinida.TabIndex = 0;
            this.rbDataIdefinida.TabStop = true;
            this.rbDataIdefinida.Text = "Data indefinida";
            this.rbDataIdefinida.UseVisualStyleBackColor = true;
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
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(576, 27);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmVendasAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVendasAbertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas em Aberto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton rbDataDefinida;
        private System.Windows.Forms.RadioButton rbDataIdefinida;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}