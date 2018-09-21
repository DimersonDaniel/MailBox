using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace MailBox.Modules.Views.Entrada
{
    public partial class OpenMail : Form
    {
        public OpenMail(string from, string subject, string conteudo, string tipo)
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            content = conteudo;
            _from = from;
            _subject = subject;
            _tipo = tipo;
        }
        private string _from = "";
        private string _subject = "";
        private string content = "";
        private string _tipo = "";



        GeckoWebBrowser GeckoWeb = new GeckoWebBrowser();
        private void OpenMail_Load(object sender, EventArgs e)
        {
            lbl_from.Text = _from;
            lbl_subject.Text = _subject;
           
            if (_tipo == "html")
            {
                GeckoWeb.Dock = DockStyle.Fill;
                GeckoWeb.LoadHtml(content);
                painel_central.Controls.Add(GeckoWeb);
            }
            else
            {
                txt_conteuto.Visible = true;
                txt_conteuto.AppendText(content);
            }
            
        }
    }
}
