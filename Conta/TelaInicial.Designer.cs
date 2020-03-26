namespace Conta
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.acessarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(226, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO THEBANK 4YOU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(527, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Conta/Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acessarConta
            // 
            this.acessarConta.BackColor = System.Drawing.Color.Black;
            this.acessarConta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.acessarConta.FlatAppearance.BorderSize = 100;
            this.acessarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.acessarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.acessarConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acessarConta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.acessarConta.Location = new System.Drawing.Point(420, 371);
            this.acessarConta.Name = "acessarConta";
            this.acessarConta.Size = new System.Drawing.Size(87, 40);
            this.acessarConta.TabIndex = 3;
            this.acessarConta.Text = "Acessar Conta";
            this.acessarConta.UseVisualStyleBackColor = false;
            this.acessarConta.Click += new System.EventHandler(this.acessarConta_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 422);
            this.Controls.Add(this.acessarConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button acessarConta;
    }
}

