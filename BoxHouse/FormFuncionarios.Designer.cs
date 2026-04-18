namespace BoxHouse
{
    partial class FormFuncionarios
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.tBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.cbCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.lbCargoFuncionario = new System.Windows.Forms.Label();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.numValorVendas = new System.Windows.Forms.NumericUpDown();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.lbValorVendas = new System.Windows.Forms.Label();
            this.gbCadastrarFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparForms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVendas)).BeginInit();
            this.gbCadastrarFuncionario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(440, 12);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(348, 176);
            this.dgvFuncionarios.TabIndex = 0;
            // 
            // tBoxNomeFuncionario
            // 
            this.tBoxNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomeFuncionario.Location = new System.Drawing.Point(7, 58);
            this.tBoxNomeFuncionario.Name = "tBoxNomeFuncionario";
            this.tBoxNomeFuncionario.Size = new System.Drawing.Size(259, 26);
            this.tBoxNomeFuncionario.TabIndex = 1;
            // 
            // cbCargoFuncionario
            // 
            this.cbCargoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargoFuncionario.FormattingEnabled = true;
            this.cbCargoFuncionario.Items.AddRange(new object[] {
            "Supervisor(a)",
            "Tosador(a)",
            "Adestrador(a)"});
            this.cbCargoFuncionario.Location = new System.Drawing.Point(6, 118);
            this.cbCargoFuncionario.Name = "cbCargoFuncionario";
            this.cbCargoFuncionario.Size = new System.Drawing.Size(260, 28);
            this.cbCargoFuncionario.TabIndex = 2;
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(4, 35);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(159, 20);
            this.lbNomeFuncionario.TabIndex = 3;
            this.lbNomeFuncionario.Text = "Nome do funcionário:";
            // 
            // lbCargoFuncionario
            // 
            this.lbCargoFuncionario.AutoSize = true;
            this.lbCargoFuncionario.Location = new System.Drawing.Point(3, 95);
            this.lbCargoFuncionario.Name = "lbCargoFuncionario";
            this.lbCargoFuncionario.Size = new System.Drawing.Size(160, 20);
            this.lbCargoFuncionario.TabIndex = 4;
            this.lbCargoFuncionario.Text = "Cargo do funcionário:";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(48, 174);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(212, 34);
            this.btnCadastrarFuncionario.TabIndex = 5;
            this.btnCadastrarFuncionario.Text = "Cadastrar novo funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // numValorVendas
            // 
            this.numValorVendas.DecimalPlaces = 2;
            this.numValorVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorVendas.Location = new System.Drawing.Point(6, 52);
            this.numValorVendas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValorVendas.Name = "numValorVendas";
            this.numValorVendas.Size = new System.Drawing.Size(336, 29);
            this.numValorVendas.TabIndex = 6;
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularComissao.Location = new System.Drawing.Point(191, 102);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(151, 29);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular comissão";
            this.btnCalcularComissao.UseVisualStyleBackColor = true;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // lbValorVendas
            // 
            this.lbValorVendas.AutoSize = true;
            this.lbValorVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVendas.Location = new System.Drawing.Point(6, 33);
            this.lbValorVendas.Name = "lbValorVendas";
            this.lbValorVendas.Size = new System.Drawing.Size(302, 16);
            this.lbValorVendas.TabIndex = 8;
            this.lbValorVendas.Text = "Valor total de vendas do funcionário selecionado:";
            // 
            // gbCadastrarFuncionario
            // 
            this.gbCadastrarFuncionario.Controls.Add(this.btnLimparForms);
            this.gbCadastrarFuncionario.Controls.Add(this.cbCargoFuncionario);
            this.gbCadastrarFuncionario.Controls.Add(this.tBoxNomeFuncionario);
            this.gbCadastrarFuncionario.Controls.Add(this.lbNomeFuncionario);
            this.gbCadastrarFuncionario.Controls.Add(this.lbCargoFuncionario);
            this.gbCadastrarFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.gbCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastrarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.gbCadastrarFuncionario.Name = "gbCadastrarFuncionario";
            this.gbCadastrarFuncionario.Size = new System.Drawing.Size(398, 214);
            this.gbCadastrarFuncionario.TabIndex = 9;
            this.gbCadastrarFuncionario.TabStop = false;
            this.gbCadastrarFuncionario.Text = "Cadastro de funcionário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbValorVendas);
            this.groupBox1.Controls.Add(this.numValorVendas);
            this.groupBox1.Controls.Add(this.btnCalcularComissao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(440, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo de comissão";
            // 
            // btnLimparForms
            // 
            this.btnLimparForms.Location = new System.Drawing.Point(266, 174);
            this.btnLimparForms.Name = "btnLimparForms";
            this.btnLimparForms.Size = new System.Drawing.Size(126, 34);
            this.btnLimparForms.TabIndex = 6;
            this.btnLimparForms.Text = "Limpar campos";
            this.btnLimparForms.UseVisualStyleBackColor = true;
            this.btnLimparForms.Click += new System.EventHandler(this.btnLimparForms_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCadastrarFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "FormFuncionarios";
            this.Text = "Box House - Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVendas)).EndInit();
            this.gbCadastrarFuncionario.ResumeLayout(false);
            this.gbCadastrarFuncionario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox tBoxNomeFuncionario;
        private System.Windows.Forms.ComboBox cbCargoFuncionario;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.Label lbCargoFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.NumericUpDown numValorVendas;
        private System.Windows.Forms.Button btnCalcularComissao;
        private System.Windows.Forms.Label lbValorVendas;
        private System.Windows.Forms.GroupBox gbCadastrarFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparForms;
    }
}