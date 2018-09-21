namespace MailBox.Modules.Views.Enviar
{
    partial class SendMail
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_send_mail = new System.Windows.Forms.Button();
            this.btn_anexo = new System.Windows.Forms.Button();
            this.txt_anexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_to_send = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_body = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_send_mail);
            this.groupBox1.Controls.Add(this.btn_anexo);
            this.groupBox1.Controls.Add(this.txt_anexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_subject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_to_send);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_send_mail
            // 
            this.btn_send_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send_mail.Image = global::MailBox.Properties.Resources.sent_mail;
            this.btn_send_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_send_mail.Location = new System.Drawing.Point(518, 81);
            this.btn_send_mail.Name = "btn_send_mail";
            this.btn_send_mail.Size = new System.Drawing.Size(111, 31);
            this.btn_send_mail.TabIndex = 4;
            this.btn_send_mail.Text = "Enviar";
            this.btn_send_mail.UseVisualStyleBackColor = true;
            this.btn_send_mail.Click += new System.EventHandler(this.btn_send_mail_Click);
            // 
            // btn_anexo
            // 
            this.btn_anexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anexo.Image = global::MailBox.Properties.Resources.icon;
            this.btn_anexo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anexo.Location = new System.Drawing.Point(382, 81);
            this.btn_anexo.Name = "btn_anexo";
            this.btn_anexo.Size = new System.Drawing.Size(121, 31);
            this.btn_anexo.TabIndex = 3;
            this.btn_anexo.Text = "Anexar";
            this.btn_anexo.UseVisualStyleBackColor = true;
            this.btn_anexo.Click += new System.EventHandler(this.btn_anexo_Click);
            // 
            // txt_anexo
            // 
            this.txt_anexo.Location = new System.Drawing.Point(97, 85);
            this.txt_anexo.Name = "txt_anexo";
            this.txt_anexo.Size = new System.Drawing.Size(279, 23);
            this.txt_anexo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anexo:";
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(97, 51);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(406, 23);
            this.txt_subject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Assunto:";
            // 
            // txt_to_send
            // 
            this.txt_to_send.Location = new System.Drawing.Point(76, 22);
            this.txt_to_send.Name = "txt_to_send";
            this.txt_to_send.Size = new System.Drawing.Size(427, 23);
            this.txt_to_send.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_body);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_body
            // 
            this.txt_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_body.Location = new System.Drawing.Point(3, 19);
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(744, 382);
            this.txt_body.TabIndex = 0;
            this.txt_body.Text = "";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SendMail";
            this.Size = new System.Drawing.Size(756, 532);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_to_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_anexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_anexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_send_mail;
        private System.Windows.Forms.RichTextBox txt_body;
    }
}
