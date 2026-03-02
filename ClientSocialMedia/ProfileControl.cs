using socialMediaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocialMedia
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            LadeProfil();
        }

        private void LadeProfil()
        {
            Nutzer n = Form1.client.LadeProfil();
            nameTb.Text = n.BenutzerName;
            mailTb.Text = n.Email; 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string reply = Form1.client.ProfilAktualisieren(nameTb.Text, mailTb.Text);
            MessageBox.Show(reply);
        }
    }
}
