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

        private async void LadeProfil()
        {
            Nutzer n = await Task.Run(() => Form1.client.LadeProfil());
            abonnentenLb.Text = $"Aktuelle Abonnenten: {n.AbonnentenAnzahl}";
            nameTb.Text = n.BenutzerName;
            mailTb.Text = n.Email; 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string reply = Form1.client.ProfilAktualisieren(nameTb.Text, mailTb.Text);
            MessageBox.Show(reply);
            LadeProfil();
        }

        private void passwortBtn_Click(object sender, EventArgs e)
        {
            if (!passwortPanel.Visible)
            {
                passwortPanel.Visible = true;
                saveBtn.Visible = false;
            }
            else
            {
                passwortPanel.Visible = false;
                saveBtn.Visible = true;
            }
        }

        private void savePassword_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Das bestätigungs Passwort stimmt nicht mit dem neuen überein");
                return;
            }
            string reply = Form1.client.PasswortAktualisieren(textBox1.Text, textBox2.Text);
            if (reply.Split(';')[0] == "-")
            {
                MessageBox.Show(reply.Split(';')[1]);
                return;
            }
            else
            {
                MessageBox.Show(reply.Split(';')[1]);
            }
            passwortPanel.Visible = false;
            saveBtn.Visible = true;
        }
    }
}
