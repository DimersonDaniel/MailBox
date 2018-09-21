using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Pop3;
using System.Threading;
using MailBox.DataBase;
using System.Text.RegularExpressions;

namespace MailBox.Modules.Views.Entrada
{
    public partial class Entrada : UserControl
    {
        public Entrada()
        {
            InitializeComponent();
        }

        CreateDb CreateDb = new CreateDb();
        private string Toemail = "dimerson.daniel@yahoo.com";
        private string Topass = "Amor167167";
        private List<string> backList = new List<string>();

        private void Entrada_Load(object sender, EventArgs e)
        {
            wacthMails();
        }
        private void startReceive()
        {
            QuerysDb querysDb = new QuerysDb();
            var emails = querysDb.SelectEmails();

            for (int key = 0; key < emails.Rows.Count; key++)
            {
                if (!backList.Contains(emails.Rows[key][1].ToString()))
                {
                    if (!string.IsNullOrWhiteSpace(emails.Rows[key][1].ToString()))
                    {
                        mail_grid.Rows.Add(false, emails.Rows[key][3].ToString(), emails.Rows[key][4].ToString(), emails.Rows[key][5].ToString(), emails.Rows[key][6].ToString());
                        backList.Add(emails.Rows[key][1].ToString());
                    }
                }
            }

            Thread thread = new Thread(() => {
               
                try
                {
                    var client = new Pop3Client();
                    client.Connect("pop.mail.yahoo.com", 995, true);
                    client.Authenticate(Toemail, Topass);
                    var count = client.GetMessageCount();
                    OpenPop.Mime.Message message = client.GetMessage(count);
                    // var mailbody = ASCIIEncoding.ASCII.GetString(message.RawMessage);
                   
                    StringBuilder builder = new StringBuilder();

                    OpenPop.Mime.MessagePart plainText = message.FindFirstPlainTextVersion();
                    if (plainText != null)
                    {
                        CreateDb.ExecuteSqlCommand($"INSERT INTO box_mail (dateId, mail_from, subject, body, tipo) VALUES('{message.Headers.Date.Trim()}','{message.Headers.From}','{message.Headers.Subject.Trim()}','{plainText.GetBodyAsText()}', 'text')");
                    }
                    else
                    {
                        // Might include a part holding html instead
                        OpenPop.Mime.MessagePart html = message.FindFirstHtmlVersion();
                        if (html != null)
                        {
                            CreateDb.ExecuteSqlCommand($"INSERT INTO box_mail (dateId, mail_from, subject, body, tipo) VALUES('{message.Headers.Date.Trim()}','{message.Headers.From}','{message.Headers.Subject.Trim()}','{html.GetBodyAsText()}', 'html')");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   // corpo_email.AppendText(ex.Message + "\r\n");
                }

            }) { IsBackground = true };
            thread.Start();
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void wacthMails()
        {
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            startReceive();
        }

        private void mail_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mail_grid.CurrentRow.Cells[3].Value.ToString()))
            {
                OpenMail openMail = new OpenMail(mail_grid.CurrentRow.Cells[1].Value.ToString(), mail_grid.CurrentRow.Cells[2].Value.ToString(), mail_grid.CurrentRow.Cells[3].Value.ToString(), mail_grid.CurrentRow.Cells[4].Value.ToString());
                openMail.ShowDialog();
            }
        }
    }
}
