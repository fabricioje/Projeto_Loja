namespace frmPrincipal
{
    partial class frmUsuarioConsultar
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
            this.dataConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataConsulta
            // 
            this.dataConsulta.AllowUserToAddRows = false;
            this.dataConsulta.AllowUserToDeleteRows = false;
            this.dataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta.Location = new System.Drawing.Point(28, 95);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.ReadOnly = true;
            this.dataConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsulta.Size = new System.Drawing.Size(731, 416);
            this.dataConsulta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite a ID ou Nome do usuário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(448, 20);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmUsuarioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmUsuarioConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
    }
}