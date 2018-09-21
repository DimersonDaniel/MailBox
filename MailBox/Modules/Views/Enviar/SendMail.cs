using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBox.Modules.Views.Enviar
{
    public partial class SendMail : UserControl
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private string Fromemail = "dimerson.daniel@gmail.com";
        private string Frompass = "dimy167167";
        private void btn_send_mail_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            try // Its a good practice to write your code in a try catch block 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Connection Object
                MailMessage message = new MailMessage(); // Email Object
                message.From = new MailAddress(Fromemail); // Sender Email
                message.To.Add(txt_to_send.Text); // Reciever emailid
                message.Body = txt_body.Text; // Body of the email
                message.Subject = txt_subject.Text; // Subject of the email
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Enabling secured Connection
                if (txt_anexo.Text != null) // ENVIA O ARQUIVO EM ANEXO
                {
                    message.Attachments.Add(new Attachment(txt_anexo.Text)); //Adding attachment
                }
                client.Credentials = new System.Net.NetworkCredential(Fromemail, Frompass); // Setting Credential of gmail account              
                client.Send(message); //Sending Email              
                Console.WriteLine("Completo");
                message = null; // Free the memory
            }
            catch (Exception ex) // Catching if any error occurs
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
           if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
               txt_anexo.Text = openFileDialog.FileName;
            }
        }
    }
}
