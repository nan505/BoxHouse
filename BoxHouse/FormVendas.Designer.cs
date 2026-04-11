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
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).BeginInit();
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
            this.cbSelecionarProdutos.Location = new System.Drawing.Point(12, 33);
            this.cbSelecionarProdutos.Name = "cbSelecionarProdutos";
            this.cbSelecionarProdutos.Size = new System.Drawing.Size(205, 28);
            this.cbSelecionarProdutos.TabIndex = 0;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.Location = new System.Drawing.Point(12, 92);
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
            this.btnAddProdutos.Location = new System.Drawing.Point(12, 124);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(154, 37);
            this.btnAddProdutos.TabIndex = 2;
            this.btnAddProdutos.Text = "Adicionar";
            this.btnAddProdutos.UseVisualStyleBackColor = true;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // lbSelecionarProdutos
            // 
            this.lbSelecionarProdutos.AutoSize = true;
            this.lbSelecionarProdutos.Location = new System.Drawing.Point(9, 17);
            this.lbSelecionarProdutos.Name = "lbSelecionarProdutos";
            this.lbSelecionarProdutos.Size = new System.Drawing.Size(102, 13);
            this.lbSelecionarProdutos.TabIndex = 3;
            this.lbSelecionarProdutos.Text = "Selecione o produto";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(9, 76);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(177, 13);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Informe a quantidade desse produto";
            // 
            // dgvProdutosAdicionados
            // 
            this.dgvProdutosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosAdicionados.Location = new System.Drawing.Point(383, 17);
            this.dgvProdutosAdicionados.Name = "dgvProdutosAdicionados";
            this.dgvProdutosAdicionados.Size = new System.Drawing.Size(405, 227);
            this.dgvProdutosAdicionados.TabIndex = 5;
            // 
            // lbValorTexto
            // 
            this.lbValorTexto.AutoSize = true;
            this.lbValorTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTexto.Location = new System.Drawing.Point(383, 251);
            this.lbValorTexto.Name = "lbValorTexto";
            this.lbValorTexto.Size = new System.Drawing.Size(115, 25);
            this.lbValorTexto.TabIndex = 6;
            this.lbValorTexto.Text = "Valor total:";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(504, 251);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(87, 25);
            this.lbValorTotal.TabIndex = 7;
            this.lbValorTotal.Text = "R$0,00";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.lbValorTexto);
            this.Controls.Add(this.dgvProdutosAdicionados);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbSelecionarProdutos);
            this.Controls.Add(this.btnAddProdutos);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.cbSelecionarProdutos);
            this.Name = "FormVendas";
            this.Text = "Box House: Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).EndInit();
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
    }
}