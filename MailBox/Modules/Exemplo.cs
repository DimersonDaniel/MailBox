using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBox.Modules
{
    class Exemplo
    {
        private string Toemail = "dimerson.daniel@yahoo.com";
        private string Topass = "Amor167167";
        private string Fromemail = "dimerson.daniel@gmail.com";
        private string Frompass = "dimy167167";
        private string ToBody = "";
        private string GetBody = "";
        private void EnviarEmail()
        {
            try // Its a good practice to write your code in a try catch block 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Connection Object
                MailMessage message = new MailMessage(); // Email Object
                message.From = new MailAddress(Fromemail); // Sender Email
                message.To.Add(Toemail); // Reciever emailid
                message.Body = ToBody; // Body of the email
                message.Subject = ""; // Subject of the email
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Enabling secured Connection
                //if (file != null) // ENVIA O ARQUIVO EM ANEXO
                //{
                //    message.Attachments.Add(new Attachment(file)); //Adding attachment
                //}
                client.Credentials = new System.Net.NetworkCredential(Fromemail, Frompass); // Setting Credential of gmail account              
                client.Send(message); //Sending Email              
                Console.WriteLine("Completo");
                message = null; // Free the memory
               
                startReceive();
            }
            catch (Exception ex) // Catching if any error occurs
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startReceive()
        {
            var client = new Pop3Client();
            client.Connect("pop.mail.yahoo.com", 995, true);
            client.Authenticate(Toemail, Topass);
            var count = client.GetMessageCount();
            OpenPop.Mime.Message message = client.GetMessage(count);
            // var mailbody = ASCIIEncoding.ASCII.GetString(message.RawMessage);
            OpenPop.Mime.MessagePart body = message.FindFirstPlainTextVersion();

            GetBody = body.GetBodyAsText();

        }
    }
}
