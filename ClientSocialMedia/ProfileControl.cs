using socialMediaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocialMedia
{
    public partial class ProfileControl : UserControl
    {
        public Action<Image> OnProfileChange;
        public Action OnAbmelden;
        public ProfileControl()
        {
            InitializeComponent();
            LadeProfil();
        }

        private async void LadeProfil()
        {
            Cursor = Cursors.WaitCursor;
            Nutzer n = await Task.Run(() => Form1.client.LadeProfil());
            abonnentenLb.Text = $"Aktuelle Abonnenten: {n.AbonnentenAnzahl}";
            nameTb.Text = n.BenutzerName;
            mailTb.Text = n.Email; 
            if (n.ProfilBild != null)
            {
                byte[] pictureBytes = Convert.FromBase64String(n.ProfilBild);
                using (MemoryStream ms = new MemoryStream(pictureBytes))
                {
                    Image img = Image.FromStream(ms);
                    profilePictureBox.Image = img;
                }
            }
            Cursor = Cursors.Default;
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
                profilePictureBtn.Visible = false;
                passwortPanel.Visible = true;
                saveBtn.Visible = false;
            }
            else
            {
                profilePictureBtn.Visible = true;
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
            else if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("Das Passwort muss mindestens 4 Zeichen lang sein");
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

        private void profilePictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Profilbild auswählen";
            dialog.Filter = "Bilder (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                string fileName = Path.GetFileName(filePath);

                profilePictureBox.Image = Image.FromFile(filePath);
                OnProfileChange?.Invoke(Image.FromFile(filePath));
                string pictureBytes = Convert.ToBase64String(File.ReadAllBytes(filePath));
                string reply = Form1.client.ProfilBild(fileName, pictureBytes);
                MessageBox.Show(reply);
            }
        }

        private void abmeldenBtn_Click(object sender, EventArgs e)
        {
            string msg = Form1.client.Abmelden();
            MessageBox.Show(msg);
            OnAbmelden?.Invoke();
        }

    }
}
