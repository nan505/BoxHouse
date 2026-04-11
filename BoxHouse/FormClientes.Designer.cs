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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // mTBoxTelefone
            // 
            this.mTBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBoxTelefone.Location = new System.Drawing.Point(34, 114);
            this.mTBoxTelefone.Mask = "(99) 00000-0000";
            this.mTBoxTelefone.Name = "mTBoxTelefone";
            this.mTBoxTelefone.Size = new System.Drawing.Size(161, 26);
            this.mTBoxTelefone.TabIndex = 0;
            // 
            // tBoxNomeCliente
            // 
            this.tBoxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomeCliente.Location = new System.Drawing.Point(34, 63);
            this.tBoxNomeCliente.Name = "tBoxNomeCliente";
            this.tBoxNomeCliente.Size = new System.Drawing.Size(161, 26);
            this.tBoxNomeCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(31, 47);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lbNomeCliente.TabIndex = 2;
            this.lbNomeCliente.Text = "Nome:";
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Location = new System.Drawing.Point(31, 98);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(103, 13);
            this.lbTelefoneCliente.TabIndex = 3;
            this.lbTelefoneCliente.Text = "Número de telefone:";
            // 
            // tBoxNomePetCliente
            // 
            this.tBoxNomePetCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomePetCliente.Location = new System.Drawing.Point(34, 166);
            this.tBoxNomePetCliente.Name = "tBoxNomePetCliente";
            this.tBoxNomePetCliente.Size = new System.Drawing.Size(161, 26);
            this.tBoxNomePetCliente.TabIndex = 4;
            // 
            // lbNomePetCliente
            // 
            this.lbNomePetCliente.AutoSize = true;
            this.lbNomePetCliente.Location = new System.Drawing.Point(31, 150);
            this.lbNomePetCliente.Name = "lbNomePetCliente";
            this.lbNomePetCliente.Size = new System.Drawing.Size(71, 13);
            this.lbNomePetCliente.TabIndex = 5;
            this.lbNomePetCliente.Text = "Nome do pet:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(34, 210);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(100, 27);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // dgvClientesCadastrados
            // 
            this.dgvClientesCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCadastrados.Location = new System.Drawing.Point(430, 47);
            this.dgvClientesCadastrados.Name = "dgvClientesCadastrados";
            this.dgvClientesCadastrados.Size = new System.Drawing.Size(358, 190);
            this.dgvClientesCadastrados.TabIndex = 7;
            // 
            // tBoxPesquisar
            // 
            this.tBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPesquisar.Location = new System.Drawing.Point(430, 253);
            this.tBoxPesquisar.Name = "tBoxPesquisar";
            this.tBoxPesquisar.Size = new System.Drawing.Size(250, 26);
            this.tBoxPesquisar.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(686, 253);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 35);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tBoxPesquisar);
            this.Controls.Add(this.dgvClientesCadastrados);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.lbNomePetCliente);
            this.Controls.Add(this.tBoxNomePetCliente);
            this.Controls.Add(this.lbTelefoneCliente);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.tBoxNomeCliente);
            this.Controls.Add(this.mTBoxTelefone);
            this.Name = "FormClientes";
            this.Text = "Box House - Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).EndInit();
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
    }
}