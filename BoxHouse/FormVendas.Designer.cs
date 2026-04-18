namespace BoxHouse
{
    partial class FormVendas
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
            this.cbSelecionarProdutos = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAddProdutos = new System.Windows.Forms.Button();
            this.lbSelecionarProdutos = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.dgvProdutosAdicionados = new System.Windows.Forms.DataGridView();
            this.lbValorTexto = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.gbAdicionarProdutos = new System.Windows.Forms.GroupBox();
            this.cbSelecionarCliente = new System.Windows.Forms.ComboBox();
            this.gbFinalizarPedido = new System.Windows.Forms.GroupBox();
            this.lbEnderecoCliente = new System.Windows.Forms.Label();
            this.tBoxEnderecoCliente = new System.Windows.Forms.TextBox();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lbSelecionarCliente = new System.Windows.Forms.Label();
            this.lbDataTexto = new System.Windows.Forms.Label();
            this.lbDataAtual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).BeginInit();
            this.gbAdicionarProdutos.SuspendLayout();
            this.gbFinalizarPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelecionarProdutos
            // 
            this.cbSelecionarProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelecionarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarProdutos.FormattingEnabled = true;
            this.cbSelecionarProdutos.Items.AddRange(new object[] {
            "Ração de cachorro",
            "Coleira pequena",
            "Petisco genérico"});
            this.cbSelecionarProdutos.Location = new System.Drawing.Point(9, 47);
            this.cbSelecionarProdutos.Name = "cbSelecionarProdutos";
            this.cbSelecionarProdutos.Size = new System.Drawing.Size(205, 28);
            this.cbSelecionarProdutos.TabIndex = 0;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.Location = new System.Drawing.Point(9, 103);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(204, 26);
            this.numQuantidade.TabIndex = 1;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdutos.Location = new System.Drawing.Point(541, 136);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(154, 31);
            this.btnAddProdutos.TabIndex = 2;
            this.btnAddProdutos.Text = "Adicionar item";
            this.btnAddProdutos.UseVisualStyleBackColor = true;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // lbSelecionarProdutos
            // 
            this.lbSelecionarProdutos.AutoSize = true;
            this.lbSelecionarProdutos.Location = new System.Drawing.Point(6, 28);
            this.lbSelecionarProdutos.Name = "lbSelecionarProdutos";
            this.lbSelecionarProdutos.Size = new System.Drawing.Size(131, 16);
            this.lbSelecionarProdutos.TabIndex = 3;
            this.lbSelecionarProdutos.Text = "Selecione o produto:";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(6, 84);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(226, 16);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Informe a quantidade desse produto:";
            // 
            // dgvProdutosAdicionados
            // 
            this.dgvProdutosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosAdicionados.Location = new System.Drawing.Point(28, 211);
            this.dgvProdutosAdicionados.Name = "dgvProdutosAdicionados";
            this.dgvProdutosAdicionados.Size = new System.Drawing.Size(355, 227);
            this.dgvProdutosAdicionados.TabIndex = 5;
            this.dgvProdutosAdicionados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProdutosAdicionados_DataBindingComplete);
            // 
            // lbValorTexto
            // 
            this.lbValorTexto.AutoSize = true;
            this.lbValorTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTexto.Location = new System.Drawing.Point(399, 211);
            this.lbValorTexto.Name = "lbValorTexto";
            this.lbValorTexto.Size = new System.Drawing.Size(115, 25);
            this.lbValorTexto.TabIndex = 6;
            this.lbValorTexto.Text = "Valor total:";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(520, 211);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(87, 25);
            this.lbValorTotal.TabIndex = 7;
            this.lbValorTotal.Text = "R$0,00";
            // 
            // gbAdicionarProdutos
            // 
            this.gbAdicionarProdutos.Controls.Add(this.cbSelecionarProdutos);
            this.gbAdicionarProdutos.Controls.Add(this.lbSelecionarProdutos);
            this.gbAdicionarProdutos.Controls.Add(this.numQuantidade);
            this.gbAdicionarProdutos.Controls.Add(this.lbQuantidade);
            this.gbAdicionarProdutos.Controls.Add(this.btnAddProdutos);
            this.gbAdicionarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdicionarProdutos.Location = new System.Drawing.Point(28, 32);
            this.gbAdicionarProdutos.Name = "gbAdicionarProdutos";
            this.gbAdicionarProdutos.Size = new System.Drawing.Size(701, 173);
            this.gbAdicionarProdutos.TabIndex = 8;
            this.gbAdicionarProdutos.TabStop = false;
            this.gbAdicionarProdutos.Text = "Seleção de produtos:";
            // 
            // cbSelecionarCliente
            // 
            this.cbSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarCliente.FormattingEnabled = true;
            this.cbSelecionarCliente.Location = new System.Drawing.Point(6, 47);
            this.cbSelecionarCliente.Name = "cbSelecionarCliente";
            this.cbSelecionarCliente.Size = new System.Drawing.Size(283, 28);
            this.cbSelecionarCliente.TabIndex = 5;
            // 
            // gbFinalizarPedido
            // 
            this.gbFinalizarPedido.Controls.Add(this.lbEnderecoCliente);
            this.gbFinalizarPedido.Controls.Add(this.tBoxEnderecoCliente);
            this.gbFinalizarPedido.Controls.Add(this.btnFinalizarPedido);
            this.gbFinalizarPedido.Controls.Add(this.lbSelecionarCliente);
            this.gbFinalizarPedido.Controls.Add(this.cbSelecionarCliente);
            this.gbFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFinalizarPedido.Location = new System.Drawing.Point(404, 253);
            this.gbFinalizarPedido.Name = "gbFinalizarPedido";
            this.gbFinalizarPedido.Size = new System.Drawing.Size(325, 185);
            this.gbFinalizarPedido.TabIndex = 9;
            this.gbFinalizarPedido.TabStop = false;
            this.gbFinalizarPedido.Text = "Finalize o pedido:";
            // 
            // lbEnderecoCliente
            // 
            this.lbEnderecoCliente.AutoSize = true;
            this.lbEnderecoCliente.Location = new System.Drawing.Point(6, 83);
            this.lbEnderecoCliente.Name = "lbEnderecoCliente";
            this.lbEnderecoCliente.Size = new System.Drawing.Size(252, 16);
            this.lbEnderecoCliente.TabIndex = 9;
            this.lbEnderecoCliente.Text = "Informe o endereço do cliente (Opcional):";
            // 
            // tBoxEnderecoCliente
            // 
            this.tBoxEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEnderecoCliente.Location = new System.Drawing.Point(6, 102);
            this.tBoxEnderecoCliente.Name = "tBoxEnderecoCliente";
            this.tBoxEnderecoCliente.Size = new System.Drawing.Size(283, 26);
            this.tBoxEnderecoCliente.TabIndex = 8;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(179, 142);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(140, 37);
            this.btnFinalizarPedido.TabIndex = 7;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lbSelecionarCliente
            // 
            this.lbSelecionarCliente.AutoSize = true;
            this.lbSelecionarCliente.Location = new System.Drawing.Point(6, 28);
            this.lbSelecionarCliente.Name = "lbSelecionarCliente";
            this.lbSelecionarCliente.Size = new System.Drawing.Size(107, 16);
            this.lbSelecionarCliente.TabIndex = 6;
            this.lbSelecionarCliente.Text = "Informe o cliente:";
            // 
            // lbDataTexto
            // 
            this.lbDataTexto.AutoSize = true;
            this.lbDataTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataTexto.Location = new System.Drawing.Point(531, 9);
            this.lbDataTexto.Name = "lbDataTexto";
            this.lbDataTexto.Size = new System.Drawing.Size(87, 20);
            this.lbDataTexto.TabIndex = 10;
            this.lbDataTexto.Text = "Data atual:";
            // 
            // lbDataAtual
            // 
            this.lbDataAtual.AutoSize = true;
            this.lbDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAtual.Location = new System.Drawing.Point(624, 9);
            this.lbDataAtual.Name = "lbDataAtual";
            this.lbDataAtual.Size = new System.Drawing.Size(99, 20);
            this.lbDataAtual.TabIndex = 11;
            this.lbDataAtual.Text = "dd/MM/yyyy";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.lbDataAtual);
            this.Controls.Add(this.lbDataTexto);
            this.Controls.Add(this.gbFinalizarPedido);
            this.Controls.Add(this.gbAdicionarProdutos);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.lbValorTexto);
            this.Controls.Add(this.dgvProdutosAdicionados);
            this.Name = "FormVendas";
            this.Text = "Box House: Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).EndInit();
            this.gbAdicionarProdutos.ResumeLayout(false);
            this.gbAdicionarProdutos.PerformLayout();
            this.gbFinalizarPedido.ResumeLayout(false);
            this.gbFinalizarPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelecionarProdutos;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAddProdutos;
        private System.Windows.Forms.Label lbSelecionarProdutos;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.DataGridView dgvProdutosAdicionados;
        private System.Windows.Forms.Label lbValorTexto;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.GroupBox gbAdicionarProdutos;
        private System.Windows.Forms.ComboBox cbSelecionarCliente;
        private System.Windows.Forms.GroupBox gbFinalizarPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label lbSelecionarCliente;
        private System.Windows.Forms.Label lbEnderecoCliente;
        private System.Windows.Forms.TextBox tBoxEnderecoCliente;
        private System.Windows.Forms.Label lbDataTexto;
        private System.Windows.Forms.Label lbDataAtual;
    }
}