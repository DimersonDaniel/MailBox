namespace MailBox
{
    partial class MailBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailBox));
            this.painel_seperior = new System.Windows.Forms.Panel();
            this.painel_central = new System.Windows.Forms.Panel();
            this.painel_lateral = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.painel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_seperior
            // 
            this.painel_seperior.BackColor = System.Drawing.Color.GhostWhite;
            this.painel_seperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_seperior.Location = new System.Drawing.Point(0, 0);
            this.painel_seperior.Name = "painel_seperior";
            this.painel_seperior.Size = new System.Drawing.Size(736, 46);
            this.painel_seperior.TabIndex = 1;
            // 
            // painel_central
            // 
            this.painel_central.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel_central.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel_central.Location = new System.Drawing.Point(132, 46);
            this.painel_central.Name = "painel_central";
            this.painel_central.Size = new System.Drawing.Size(604, 443);
            this.painel_central.TabIndex = 2;
            // 
            // painel_lateral
            // 
            this.painel_lateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel_lateral.Controls.Add(this.button5);
            this.painel_lateral.Controls.Add(this.button4);
            this.painel_lateral.Controls.Add(this.button3);
            this.painel_lateral.Controls.Add(this.button1);
            this.painel_lateral.Controls.Add(this.button2);
            this.painel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_lateral.Location = new System.Drawing.Point(0, 46);
            this.painel_lateral.Name = "painel_lateral";
            this.painel_lateral.Size = new System.Drawing.Size(131, 443);
            this.painel_lateral.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Lixeira";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(2, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "  Favoritos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "    Importantes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MailBox.Properties.Resources.pen_on_square_of_paper_interface_symbol;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = " Escrever";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Entrada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 489);
            this.Controls.Add(this.painel_lateral);
            this.Controls.Add(this.painel_central);
            this.Controls.Add(this.painel_seperior);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MailBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailBox";
            this.Load += new System.EventHandler(this.MailBox_Load);
            this.painel_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painel_seperior;
        private System.Windows.Forms.Panel painel_central;
        private System.Windows.Forms.Panel painel_lateral;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

