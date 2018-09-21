using MailBox.DataBase;
using MailBox.Modules.Views;
using MailBox.Modules.Views.Entrada;
using MailBox.Modules.Views.Enviar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBox
{
    public partial class MailBox : Form
    {
        public MailBox()
        {
            InitializeComponent();
        }

        private void MailBox_Load(object sender, EventArgs e)
        {

            CreateDb createDb = new CreateDb();
            createDb.execute();
            Entrada entrada = new Entrada();
            entrada.Dock = DockStyle.Fill;
            Modules.ViewController.Controller.Entrada = entrada;
            painel_central.Controls.Add(entrada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Modules.ViewController.Controller.Enviar != null)
            {
                painel_central.Controls.Clear();
                painel_central.Controls.Add(Modules.ViewController.Controller.Enviar);
            }
            else
            {
                painel_central.Controls.Clear();
                SendMail sendMail = new SendMail();
                sendMail.Dock = DockStyle.Fill;
                Modules.ViewController.Controller.Enviar = sendMail;
                painel_central.Controls.Add(sendMail);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Modules.ViewController.Controller.Entrada != null)
            {
                painel_central.Controls.Clear();
                painel_central.Controls.Add(Modules.ViewController.Controller.Entrada);
            }
            else
            {
                Entrada entrada = new Entrada();
                entrada.Dock = DockStyle.Fill;
                Modules.ViewController.Controller.Entrada = entrada;
                painel_central.Controls.Add(entrada);
            }
            
        }
    }
}
