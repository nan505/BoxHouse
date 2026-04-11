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
            this.SuspendLayout();
            // 
            // cbClientesCadastrados
            // 
            this.cbClientesCadastrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientesCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientesCadastrados.FormattingEnabled = true;
            this.cbClientesCadastrados.Location = new System.Drawing.Point(46, 67);
            this.cbClientesCadastrados.Name = "cbClientesCadastrados";
            this.cbClientesCadastrados.Size = new System.Drawing.Size(200, 28);
            this.cbClientesCadastrados.TabIndex = 0;
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbClientesCadastrados);
            this.Name = "FormEntregas";
            this.Text = "FormEntregas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientesCadastrados;
    }
}