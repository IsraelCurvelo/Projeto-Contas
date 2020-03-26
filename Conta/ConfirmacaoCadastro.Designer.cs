namespace Conta
{
    partial class ConfirmacaoCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textExibicaoDados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirme seus dados";
            // 
            // textExibicaoDados
            // 
            this.textExibicaoDados.Location = new System.Drawing.Point(42, 49);
            this.textExibicaoDados.Multiline = true;
            this.textExibicaoDados.Name = "textExibicaoDados";
            this.textExibicaoDados.Size = new System.Drawing.Size(514, 214);
            this.textExibicaoDados.TabIndex = 1;
            this.textExibicaoDados.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConfirmacaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 361);
            this.Controls.Add(this.textExibicaoDados);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmacaoCadastro";
            this.Text = "ConfirmacaoCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textExibicaoDados;
    }
}