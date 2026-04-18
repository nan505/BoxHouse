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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDataAtual = new System.Windows.Forms.Label();
            this.lbDataTexto = new System.Windows.Forms.Label();
            this.btnLimparForms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastradas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClientesCadastrados
            // 
            this.cbClientesCadastrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientesCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientesCadastrados.FormattingEnabled = true;
            this.cbClientesCadastrados.Location = new System.Drawing.Point(6, 42);
            this.cbClientesCadastrados.Name = "cbClientesCadastrados";
            this.cbClientesCadastrados.Size = new System.Drawing.Size(282, 28);
            this.cbClientesCadastrados.TabIndex = 0;
            // 
            // lbClienteCadastrado
            // 
            this.lbClienteCadastrado.AutoSize = true;
            this.lbClienteCadastrado.Location = new System.Drawing.Point(3, 26);
            this.lbClienteCadastrado.Name = "lbClienteCadastrado";
            this.lbClienteCadastrado.Size = new System.Drawing.Size(124, 16);
            this.lbClienteCadastrado.TabIndex = 1;
            this.lbClienteCadastrado.Text = "Selecione o cliente:";
            // 
            // tBoxEndereco
            // 
            this.tBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEndereco.Location = new System.Drawing.Point(6, 91);
            this.tBoxEndereco.Name = "tBoxEndereco";
            this.tBoxEndereco.Size = new System.Drawing.Size(282, 26);
            this.tBoxEndereco.TabIndex = 2;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(3, 75);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(126, 16);
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
            this.cbStatusEntrega.Location = new System.Drawing.Point(294, 42);
            this.cbStatusEntrega.Name = "cbStatusEntrega";
            this.cbStatusEntrega.Size = new System.Drawing.Size(293, 28);
            this.cbStatusEntrega.TabIndex = 4;
            // 
            // lbStatusEntrega
            // 
            this.lbStatusEntrega.AutoSize = true;
            this.lbStatusEntrega.Location = new System.Drawing.Point(291, 26);
            this.lbStatusEntrega.Name = "lbStatusEntrega";
            this.lbStatusEntrega.Size = new System.Drawing.Size(115, 16);
            this.lbStatusEntrega.TabIndex = 5;
            this.lbStatusEntrega.Text = "Status de entrega:";
            // 
            // dgvEntregasCadastradas
            // 
            this.dgvEntregasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasCadastradas.Location = new System.Drawing.Point(12, 248);
            this.dgvEntregasCadastradas.Name = "dgvEntregasCadastradas";
            this.dgvEntregasCadastradas.Size = new System.Drawing.Size(601, 190);
            this.dgvEntregasCadastradas.TabIndex = 6;
            this.dgvEntregasCadastradas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEntregasCadastradas_DataBindingComplete);
            // 
            // btnAddEntrega
            // 
            this.btnAddEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntrega.Location = new System.Drawing.Point(6, 194);
            this.btnAddEntrega.Name = "btnAddEntrega";
            this.btnAddEntrega.Size = new System.Drawing.Size(191, 30);
            this.btnAddEntrega.TabIndex = 7;
            this.btnAddEntrega.Text = "Adicionar nova entrega";
            this.btnAddEntrega.UseVisualStyleBackColor = true;
            this.btnAddEntrega.Click += new System.EventHandler(this.btnAddEntrega_Click);
            // 
            // btnAtualizarStatus
            // 
            this.btnAtualizarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarStatus.Location = new System.Drawing.Point(294, 83);
            this.btnAtualizarStatus.Name = "btnAtualizarStatus";
            this.btnAtualizarStatus.Size = new System.Drawing.Size(174, 34);
            this.btnAtualizarStatus.TabIndex = 8;
            this.btnAtualizarStatus.Text = "Atualizar status de entrega";
            this.btnAtualizarStatus.UseVisualStyleBackColor = true;
            this.btnAtualizarStatus.Click += new System.EventHandler(this.btnAtualizarStatus_Click);
            // 
            // btnFiltroStatus
            // 
            this.btnFiltroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroStatus.Location = new System.Drawing.Point(474, 83);
            this.btnFiltroStatus.Name = "btnFiltroStatus";
            this.btnFiltroStatus.Size = new System.Drawing.Size(113, 34);
            this.btnFiltroStatus.TabIndex = 9;
            this.btnFiltroStatus.Text = "Filtrar por status";
            this.btnFiltroStatus.UseVisualStyleBackColor = true;
            this.btnFiltroStatus.Click += new System.EventHandler(this.btnFiltroStatus_Click);
            // 
            // btnResetarFiltro
            // 
            this.btnResetarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetarFiltro.Location = new System.Drawing.Point(474, 123);
            this.btnResetarFiltro.Name = "btnResetarFiltro";
            this.btnResetarFiltro.Size = new System.Drawing.Size(113, 34);
            this.btnResetarFiltro.TabIndex = 10;
            this.btnResetarFiltro.Text = "Limpar filtro";
            this.btnResetarFiltro.UseVisualStyleBackColor = true;
            this.btnResetarFiltro.Click += new System.EventHandler(this.btnResetarFiltro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimparForms);
            this.groupBox1.Controls.Add(this.lbDataAtual);
            this.groupBox1.Controls.Add(this.lbDataTexto);
            this.groupBox1.Controls.Add(this.cbStatusEntrega);
            this.groupBox1.Controls.Add(this.btnResetarFiltro);
            this.groupBox1.Controls.Add(this.cbClientesCadastrados);
            this.groupBox1.Controls.Add(this.btnFiltroStatus);
            this.groupBox1.Controls.Add(this.lbClienteCadastrado);
            this.groupBox1.Controls.Add(this.btnAddEntrega);
            this.groupBox1.Controls.Add(this.btnAtualizarStatus);
            this.groupBox1.Controls.Add(this.tBoxEndereco);
            this.groupBox1.Controls.Add(this.lbEndereco);
            this.groupBox1.Controls.Add(this.lbStatusEntrega);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciamento de entregas:";
            // 
            // lbDataAtual
            // 
            this.lbDataAtual.AutoSize = true;
            this.lbDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAtual.Location = new System.Drawing.Point(470, 199);
            this.lbDataAtual.Name = "lbDataAtual";
            this.lbDataAtual.Size = new System.Drawing.Size(99, 20);
            this.lbDataAtual.TabIndex = 12;
            this.lbDataAtual.Text = "dd/MM/yyyy";
            // 
            // lbDataTexto
            // 
            this.lbDataTexto.AutoSize = true;
            this.lbDataTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataTexto.Location = new System.Drawing.Point(377, 199);
            this.lbDataTexto.Name = "lbDataTexto";
            this.lbDataTexto.Size = new System.Drawing.Size(87, 20);
            this.lbDataTexto.TabIndex = 11;
            this.lbDataTexto.Text = "Data atual:";
            // 
            // btnLimparForms
            // 
            this.btnLimparForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForms.Location = new System.Drawing.Point(203, 194);
            this.btnLimparForms.Name = "btnLimparForms";
            this.btnLimparForms.Size = new System.Drawing.Size(128, 30);
            this.btnLimparForms.TabIndex = 13;
            this.btnLimparForms.Text = "Limpar campos";
            this.btnLimparForms.UseVisualStyleBackColor = true;
            this.btnLimparForms.Click += new System.EventHandler(this.btnLimparForms_Click);
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEntregasCadastradas);
            this.Name = "FormEntregas";
            this.Text = "Box House - Entregas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastradas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDataTexto;
        private System.Windows.Forms.Label lbDataAtual;
        private System.Windows.Forms.Button btnLimparForms;
    }
}