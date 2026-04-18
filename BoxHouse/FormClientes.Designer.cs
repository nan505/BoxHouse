namespace BoxHouse
{
    partial class FormClientes
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
            this.mTBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbTelefoneCliente = new System.Windows.Forms.Label();
            this.tBoxNomePetCliente = new System.Windows.Forms.TextBox();
            this.lbNomePetCliente = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.dgvClientesCadastrados = new System.Windows.Forms.DataGridView();
            this.tBoxPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbCadastroCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparForms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).BeginInit();
            this.gbCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTBoxTelefone
            // 
            this.mTBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBoxTelefone.Location = new System.Drawing.Point(6, 132);
            this.mTBoxTelefone.Mask = "(99) 00000-0000";
            this.mTBoxTelefone.Name = "mTBoxTelefone";
            this.mTBoxTelefone.Size = new System.Drawing.Size(210, 35);
            this.mTBoxTelefone.TabIndex = 0;
            // 
            // tBoxNomeCliente
            // 
            this.tBoxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomeCliente.Location = new System.Drawing.Point(7, 54);
            this.tBoxNomeCliente.Name = "tBoxNomeCliente";
            this.tBoxNomeCliente.Size = new System.Drawing.Size(210, 35);
            this.tBoxNomeCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(3, 31);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(55, 20);
            this.lbNomeCliente.TabIndex = 2;
            this.lbNomeCliente.Text = "Nome:";
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Location = new System.Drawing.Point(3, 109);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(153, 20);
            this.lbTelefoneCliente.TabIndex = 3;
            this.lbTelefoneCliente.Text = "Número de telefone:";
            // 
            // tBoxNomePetCliente
            // 
            this.tBoxNomePetCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomePetCliente.Location = new System.Drawing.Point(7, 210);
            this.tBoxNomePetCliente.Name = "tBoxNomePetCliente";
            this.tBoxNomePetCliente.Size = new System.Drawing.Size(210, 35);
            this.tBoxNomePetCliente.TabIndex = 4;
            // 
            // lbNomePetCliente
            // 
            this.lbNomePetCliente.AutoSize = true;
            this.lbNomePetCliente.Location = new System.Drawing.Point(3, 187);
            this.lbNomePetCliente.Name = "lbNomePetCliente";
            this.lbNomePetCliente.Size = new System.Drawing.Size(104, 20);
            this.lbNomePetCliente.TabIndex = 5;
            this.lbNomePetCliente.Text = "Nome do pet:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(7, 261);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(182, 35);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = "Cadastrar novo cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // dgvClientesCadastrados
            // 
            this.dgvClientesCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCadastrados.Location = new System.Drawing.Point(391, 18);
            this.dgvClientesCadastrados.Name = "dgvClientesCadastrados";
            this.dgvClientesCadastrados.Size = new System.Drawing.Size(397, 239);
            this.dgvClientesCadastrados.TabIndex = 7;
            this.dgvClientesCadastrados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvClientesCadastrados_DataBindingComplete);
            // 
            // tBoxPesquisar
            // 
            this.tBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPesquisar.Location = new System.Drawing.Point(391, 289);
            this.tBoxPesquisar.Name = "tBoxPesquisar";
            this.tBoxPesquisar.Size = new System.Drawing.Size(289, 35);
            this.tBoxPesquisar.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(686, 289);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 35);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gbCadastroCliente
            // 
            this.gbCadastroCliente.Controls.Add(this.btnLimparForms);
            this.gbCadastroCliente.Controls.Add(this.tBoxNomeCliente);
            this.gbCadastroCliente.Controls.Add(this.lbNomeCliente);
            this.gbCadastroCliente.Controls.Add(this.mTBoxTelefone);
            this.gbCadastroCliente.Controls.Add(this.lbTelefoneCliente);
            this.gbCadastroCliente.Controls.Add(this.btnCadastrarCliente);
            this.gbCadastroCliente.Controls.Add(this.tBoxNomePetCliente);
            this.gbCadastroCliente.Controls.Add(this.lbNomePetCliente);
            this.gbCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroCliente.Name = "gbCadastroCliente";
            this.gbCadastroCliente.Size = new System.Drawing.Size(373, 312);
            this.gbCadastroCliente.TabIndex = 10;
            this.gbCadastroCliente.TabStop = false;
            this.gbCadastroCliente.Text = "Cadastrar novo cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite o nome do cliente para pesquisar:";
            // 
            // btnLimparForms
            // 
            this.btnLimparForms.Location = new System.Drawing.Point(195, 261);
            this.btnLimparForms.Name = "btnLimparForms";
            this.btnLimparForms.Size = new System.Drawing.Size(128, 35);
            this.btnLimparForms.TabIndex = 7;
            this.btnLimparForms.Text = "Limpar campos";
            this.btnLimparForms.UseVisualStyleBackColor = true;
            this.btnLimparForms.Click += new System.EventHandler(this.btnLimparForms_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCadastroCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tBoxPesquisar);
            this.Controls.Add(this.dgvClientesCadastrados);
            this.Name = "FormClientes";
            this.Text = "Box House - Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).EndInit();
            this.gbCadastroCliente.ResumeLayout(false);
            this.gbCadastroCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTBoxTelefone;
        private System.Windows.Forms.TextBox tBoxNomeCliente;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbTelefoneCliente;
        private System.Windows.Forms.TextBox tBoxNomePetCliente;
        private System.Windows.Forms.Label lbNomePetCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.DataGridView dgvClientesCadastrados;
        private System.Windows.Forms.TextBox tBoxPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbCadastroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparForms;
    }
}