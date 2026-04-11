namespace BoxHouse
{
    partial class FormEntregas
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
            this.cbClientesCadastrados = new System.Windows.Forms.ComboBox();
            this.lbClienteCadastrado = new System.Windows.Forms.Label();
            this.tBoxEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.cbStatusEntrega = new System.Windows.Forms.ComboBox();
            this.lbStatusEntrega = new System.Windows.Forms.Label();
            this.dgvEntregasCadastradas = new System.Windows.Forms.DataGridView();
            this.btnAddEntrega = new System.Windows.Forms.Button();
            this.btnAtualizarStatus = new System.Windows.Forms.Button();
            this.btnFiltroStatus = new System.Windows.Forms.Button();
            this.btnResetarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastradas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClientesCadastrados
            // 
            this.cbClientesCadastrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientesCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientesCadastrados.FormattingEnabled = true;
            this.cbClientesCadastrados.Location = new System.Drawing.Point(46, 67);
            this.cbClientesCadastrados.Name = "cbClientesCadastrados";
            this.cbClientesCadastrados.Size = new System.Drawing.Size(282, 28);
            this.cbClientesCadastrados.TabIndex = 0;
            // 
            // lbClienteCadastrado
            // 
            this.lbClienteCadastrado.AutoSize = true;
            this.lbClienteCadastrado.Location = new System.Drawing.Point(43, 51);
            this.lbClienteCadastrado.Name = "lbClienteCadastrado";
            this.lbClienteCadastrado.Size = new System.Drawing.Size(100, 13);
            this.lbClienteCadastrado.TabIndex = 1;
            this.lbClienteCadastrado.Text = "Selecione o cliente:";
            // 
            // tBoxEndereco
            // 
            this.tBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEndereco.Location = new System.Drawing.Point(46, 135);
            this.tBoxEndereco.Name = "tBoxEndereco";
            this.tBoxEndereco.Size = new System.Drawing.Size(282, 26);
            this.tBoxEndereco.TabIndex = 2;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(43, 119);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(102, 13);
            this.lbEndereco.TabIndex = 3;
            this.lbEndereco.Text = "Informe o endereço:";
            // 
            // cbStatusEntrega
            // 
            this.cbStatusEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusEntrega.FormattingEnabled = true;
            this.cbStatusEntrega.Items.AddRange(new object[] {
            "Pendente",
            "Saiu para entrega",
            "Entregue"});
            this.cbStatusEntrega.Location = new System.Drawing.Point(46, 193);
            this.cbStatusEntrega.Name = "cbStatusEntrega";
            this.cbStatusEntrega.Size = new System.Drawing.Size(282, 28);
            this.cbStatusEntrega.TabIndex = 4;
            // 
            // lbStatusEntrega
            // 
            this.lbStatusEntrega.AutoSize = true;
            this.lbStatusEntrega.Location = new System.Drawing.Point(43, 177);
            this.lbStatusEntrega.Name = "lbStatusEntrega";
            this.lbStatusEntrega.Size = new System.Drawing.Size(94, 13);
            this.lbStatusEntrega.TabIndex = 5;
            this.lbStatusEntrega.Text = "Status de entrega:";
            // 
            // dgvEntregasCadastradas
            // 
            this.dgvEntregasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasCadastradas.Location = new System.Drawing.Point(352, 51);
            this.dgvEntregasCadastradas.Name = "dgvEntregasCadastradas";
            this.dgvEntregasCadastradas.Size = new System.Drawing.Size(436, 313);
            this.dgvEntregasCadastradas.TabIndex = 6;
            // 
            // btnAddEntrega
            // 
            this.btnAddEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntrega.Location = new System.Drawing.Point(46, 240);
            this.btnAddEntrega.Name = "btnAddEntrega";
            this.btnAddEntrega.Size = new System.Drawing.Size(143, 30);
            this.btnAddEntrega.TabIndex = 7;
            this.btnAddEntrega.Text = "Adicionar entrega";
            this.btnAddEntrega.UseVisualStyleBackColor = true;
            this.btnAddEntrega.Click += new System.EventHandler(this.btnAddEntrega_Click);
            // 
            // btnAtualizarStatus
            // 
            this.btnAtualizarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarStatus.Location = new System.Drawing.Point(195, 240);
            this.btnAtualizarStatus.Name = "btnAtualizarStatus";
            this.btnAtualizarStatus.Size = new System.Drawing.Size(133, 30);
            this.btnAtualizarStatus.TabIndex = 8;
            this.btnAtualizarStatus.Text = "Atualizar status";
            this.btnAtualizarStatus.UseVisualStyleBackColor = true;
            this.btnAtualizarStatus.Click += new System.EventHandler(this.btnAtualizarStatus_Click);
            // 
            // btnFiltroStatus
            // 
            this.btnFiltroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroStatus.Location = new System.Drawing.Point(46, 293);
            this.btnFiltroStatus.Name = "btnFiltroStatus";
            this.btnFiltroStatus.Size = new System.Drawing.Size(143, 31);
            this.btnFiltroStatus.TabIndex = 9;
            this.btnFiltroStatus.Text = "Filtrar por status";
            this.btnFiltroStatus.UseVisualStyleBackColor = true;
            this.btnFiltroStatus.Click += new System.EventHandler(this.btnFiltroStatus_Click);
            // 
            // btnResetarFiltro
            // 
            this.btnResetarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetarFiltro.Location = new System.Drawing.Point(195, 293);
            this.btnResetarFiltro.Name = "btnResetarFiltro";
            this.btnResetarFiltro.Size = new System.Drawing.Size(133, 31);
            this.btnResetarFiltro.TabIndex = 10;
            this.btnResetarFiltro.Text = "Limpar filtro";
            this.btnResetarFiltro.UseVisualStyleBackColor = true;
            this.btnResetarFiltro.Click += new System.EventHandler(this.btnResetarFiltro_Click);
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetarFiltro);
            this.Controls.Add(this.btnFiltroStatus);
            this.Controls.Add(this.btnAtualizarStatus);
            this.Controls.Add(this.btnAddEntrega);
            this.Controls.Add(this.dgvEntregasCadastradas);
            this.Controls.Add(this.lbStatusEntrega);
            this.Controls.Add(this.cbStatusEntrega);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.tBoxEndereco);
            this.Controls.Add(this.lbClienteCadastrado);
            this.Controls.Add(this.cbClientesCadastrados);
            this.Name = "FormEntregas";
            this.Text = "Box House - Entregas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientesCadastrados;
        private System.Windows.Forms.Label lbClienteCadastrado;
        private System.Windows.Forms.TextBox tBoxEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.ComboBox cbStatusEntrega;
        private System.Windows.Forms.Label lbStatusEntrega;
        private System.Windows.Forms.DataGridView dgvEntregasCadastradas;
        private System.Windows.Forms.Button btnAddEntrega;
        private System.Windows.Forms.Button btnAtualizarStatus;
        private System.Windows.Forms.Button btnFiltroStatus;
        private System.Windows.Forms.Button btnResetarFiltro;
    }
}