namespace frmPrincipal
{
    partial class frmVenda
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.gpbVenda = new System.Windows.Forms.GroupBox();
            this.btnExluirItem = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.dataConsulta = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPrazoVenda = new System.Windows.Forms.DateTimePicker();
            this.gpbPagamento = new System.Windows.Forms.GroupBox();
            this.cbQtdParcelas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).BeginInit();
            this.gpbPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(116, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(534, 24);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do cliente";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(663, 21);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(94, 27);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar Cliente";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // gpbVenda
            // 
            this.gpbVenda.Controls.Add(this.btnExluirItem);
            this.gpbVenda.Controls.Add(this.btnFinalizarPedido);
            this.gpbVenda.Controls.Add(this.btnIncluir);
            this.gpbVenda.Controls.Add(this.label6);
            this.gpbVenda.Controls.Add(this.txtValorTotal);
            this.gpbVenda.Controls.Add(this.numericQuantidade);
            this.gpbVenda.Controls.Add(this.btnLocalizarProduto);
            this.gpbVenda.Controls.Add(this.label5);
            this.gpbVenda.Controls.Add(this.txtValorProduto);
            this.gpbVenda.Controls.Add(this.label4);
            this.gpbVenda.Controls.Add(this.label3);
            this.gpbVenda.Controls.Add(this.txtCodProduto);
            this.gpbVenda.Controls.Add(this.label2);
            this.gpbVenda.Controls.Add(this.txtCodVenda);
            this.gpbVenda.Controls.Add(this.dataConsulta);
            this.gpbVenda.Location = new System.Drawing.Point(17, 54);
            this.gpbVenda.Name = "gpbVenda";
            this.gpbVenda.Size = new System.Drawing.Size(740, 373);
            this.gpbVenda.TabIndex = 3;
            this.gpbVenda.TabStop = false;
            this.gpbVenda.Text = "Nova Venda";
            // 
            // btnExluirItem
            // 
            this.btnExluirItem.Location = new System.Drawing.Point(388, 136);
            this.btnExluirItem.Name = "btnExluirItem";
            this.btnExluirItem.Size = new System.Drawing.Size(116, 25);
            this.btnExluirItem.TabIndex = 20;
            this.btnExluirItem.Text = "Excluir Item da Lista";
            this.btnExluirItem.UseVisualStyleBackColor = true;
            this.btnExluirItem.Click += new System.EventHandler(this.btnExluirItem_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Enabled = false;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(567, 85);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(130, 39);
            this.btnFinalizarPedido.TabIndex = 19;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(248, 136);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(91, 25);
            this.btnIncluir.TabIndex = 18;
            this.btnIncluir.Text = "Incluir na lista";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(567, 24);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(154, 38);
            this.txtValorTotal.TabIndex = 11;
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(116, 104);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(100, 20);
            this.numericQuantidade.TabIndex = 10;
            this.numericQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.Location = new System.Drawing.Point(248, 63);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(104, 25);
            this.btnLocalizarProduto.TabIndex = 9;
            this.btnLocalizarProduto.Text = "Localizar Produto";
            this.btnLocalizarProduto.UseVisualStyleBackColor = true;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Enabled = false;
            this.txtValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProduto.Location = new System.Drawing.Point(116, 141);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(100, 26);
            this.txtValorProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código do Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(116, 67);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 21);
            this.txtCodProduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código da Venda";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Enabled = false;
            this.txtCodVenda.Location = new System.Drawing.Point(116, 30);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(100, 20);
            this.txtCodVenda.TabIndex = 1;
            // 
            // dataConsulta
            // 
            this.dataConsulta.AllowUserToAddRows = false;
            this.dataConsulta.AllowUserToDeleteRows = false;
            this.dataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta.Location = new System.Drawing.Point(18, 177);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.ReadOnly = true;
            this.dataConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsulta.Size = new System.Drawing.Size(703, 183);
            this.dataConsulta.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(573, 24);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(148, 67);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(105, 69);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(119, 22);
            this.txtValorPago.TabIndex = 15;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(106, 17);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(119, 22);
            this.txtDesconto.TabIndex = 13;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Forma de pagamento";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "À VISTA",
            "A PRAZO"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(402, 20);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(121, 24);
            this.cbFormaPagamento.TabIndex = 21;
            this.cbFormaPagamento.SelectedValueChanged += new System.EventHandler(this.cbFormaPagamento_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Prazo de pagamento";
            // 
            // dtpPrazoVenda
            // 
            this.dtpPrazoVenda.Enabled = false;
            this.dtpPrazoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrazoVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazoVenda.Location = new System.Drawing.Point(402, 79);
            this.dtpPrazoVenda.Name = "dtpPrazoVenda";
            this.dtpPrazoVenda.Size = new System.Drawing.Size(102, 21);
            this.dtpPrazoVenda.TabIndex = 23;
            // 
            // gpbPagamento
            // 
            this.gpbPagamento.Controls.Add(this.cbQtdParcelas);
            this.gpbPagamento.Controls.Add(this.dtpPrazoVenda);
            this.gpbPagamento.Controls.Add(this.label11);
            this.gpbPagamento.Controls.Add(this.label8);
            this.gpbPagamento.Controls.Add(this.label10);
            this.gpbPagamento.Controls.Add(this.txtDesconto);
            this.gpbPagamento.Controls.Add(this.cbFormaPagamento);
            this.gpbPagamento.Controls.Add(this.label7);
            this.gpbPagamento.Controls.Add(this.label9);
            this.gpbPagamento.Controls.Add(this.txtValorPago);
            this.gpbPagamento.Controls.Add(this.btnFinalizar);
            this.gpbPagamento.Enabled = false;
            this.gpbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPagamento.Location = new System.Drawing.Point(17, 433);
            this.gpbPagamento.Name = "gpbPagamento";
            this.gpbPagamento.Size = new System.Drawing.Size(740, 117);
            this.gpbPagamento.TabIndex = 4;
            this.gpbPagamento.TabStop = false;
            this.gpbPagamento.Text = "Pagamento";
            // 
            // cbQtdParcelas
            // 
            this.cbQtdParcelas.Enabled = false;
            this.cbQtdParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQtdParcelas.FormattingEnabled = true;
            this.cbQtdParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQtdParcelas.Location = new System.Drawing.Point(402, 49);
            this.cbQtdParcelas.Name = "cbQtdParcelas";
            this.cbQtdParcelas.Size = new System.Drawing.Size(121, 24);
            this.cbQtdParcelas.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Qtd. de Parcelas";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gpbPagamento);
            this.Controls.Add(this.gpbVenda);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.gpbVenda.ResumeLayout(false);
            this.gpbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).EndInit();
            this.gpbPagamento.ResumeLayout(false);
            this.gpbPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.GroupBox gpbVenda;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.Button btnLocalizarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.DataGridView dataConsulta;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.DateTimePicker dtpPrazoVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbPagamento;
        private System.Windows.Forms.ComboBox cbQtdParcelas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExluirItem;
    }
}