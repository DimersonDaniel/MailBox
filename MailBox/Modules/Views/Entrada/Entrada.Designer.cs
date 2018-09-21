namespace MailBox.Modules.Views.Entrada
{
    partial class Entrada
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
            this.painel_lateral = new System.Windows.Forms.Panel();
            this.mail_grid = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painel_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_lateral
            // 
            this.painel_lateral.AutoScroll = true;
            this.painel_lateral.Controls.Add(this.mail_grid);
            this.painel_lateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_lateral.Location = new System.Drawing.Point(0, 0);
            this.painel_lateral.Name = "painel_lateral";
            this.painel_lateral.Size = new System.Drawing.Size(909, 513);
            this.painel_lateral.TabIndex = 1;
            // 
            // mail_grid
            // 
            this.mail_grid.AllowUserToAddRows = false;
            this.mail_grid.BackgroundColor = System.Drawing.Color.White;
            this.mail_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mail_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.from,
            this.assunto,
            this.content,
            this.tipo});
            this.mail_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mail_grid.Location = new System.Drawing.Point(0, 0);
            this.mail_grid.Name = "mail_grid";
            this.mail_grid.ReadOnly = true;
            this.mail_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mail_grid.Size = new System.Drawing.Size(909, 513);
            this.mail_grid.TabIndex = 0;
            this.mail_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mail_grid_CellDoubleClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 20;
            // 
            // from
            // 
            this.from.HeaderText = "De:";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Width = 300;
            // 
            // assunto
            // 
            this.assunto.HeaderText = "Assunto:";
            this.assunto.Name = "assunto";
            this.assunto.ReadOnly = true;
            this.assunto.Width = 300;
            // 
            // content
            // 
            this.content.HeaderText = "Corpo:";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Width = 600;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.painel_lateral);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.Name = "Entrada";
            this.Size = new System.Drawing.Size(909, 513);
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.painel_lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mail_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painel_lateral;
        private System.Windows.Forms.DataGridView mail_grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn assunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}
