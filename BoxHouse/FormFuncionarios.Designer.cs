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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVendas)).BeginInit();
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
            this.tBoxNomeFuncionario.Location = new System.Drawing.Point(12, 56);
            this.tBoxNomeFuncionario.Name = "tBoxNomeFuncionario";
            this.tBoxNomeFuncionario.Size = new System.Drawing.Size(199, 26);
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
            this.cbCargoFuncionario.Location = new System.Drawing.Point(12, 108);
            this.cbCargoFuncionario.Name = "cbCargoFuncionario";
            this.cbCargoFuncionario.Size = new System.Drawing.Size(199, 28);
            this.cbCargoFuncionario.TabIndex = 2;
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(9, 40);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(108, 13);
            this.lbNomeFuncionario.TabIndex = 3;
            this.lbNomeFuncionario.Text = "Nome do funcionário:";
            // 
            // lbCargoFuncionario
            // 
            this.lbCargoFuncionario.AutoSize = true;
            this.lbCargoFuncionario.Location = new System.Drawing.Point(9, 92);
            this.lbCargoFuncionario.Name = "lbCargoFuncionario";
            this.lbCargoFuncionario.Size = new System.Drawing.Size(108, 13);
            this.lbCargoFuncionario.TabIndex = 4;
            this.lbCargoFuncionario.Text = "Cargo do funcionário:";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(12, 154);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(104, 34);
            this.btnCadastrarFuncionario.TabIndex = 5;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // numValorVendas
            // 
            this.numValorVendas.DecimalPlaces = 2;
            this.numValorVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorVendas.Location = new System.Drawing.Point(440, 221);
            this.numValorVendas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValorVendas.Name = "numValorVendas";
            this.numValorVendas.Size = new System.Drawing.Size(191, 26);
            this.numValorVendas.TabIndex = 6;
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.Location = new System.Drawing.Point(637, 221);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(151, 26);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular comissão";
            this.btnCalcularComissao.UseVisualStyleBackColor = true;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // lbValorVendas
            // 
            this.lbValorVendas.AutoSize = true;
            this.lbValorVendas.Location = new System.Drawing.Point(437, 205);
            this.lbValorVendas.Name = "lbValorVendas";
            this.lbValorVendas.Size = new System.Drawing.Size(157, 13);
            this.lbValorVendas.TabIndex = 8;
            this.lbValorVendas.Text = "Valor de vendas do funcionário:";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValorVendas);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.numValorVendas);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.lbCargoFuncionario);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.cbCargoFuncionario);
            this.Controls.Add(this.tBoxNomeFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "FormFuncionarios";
            this.Text = "Box House - Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}