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
    public partial class UserOverviewControl : UserControl
    {
        private int nutzerId;
        public UserOverviewControl()
        {
            InitializeComponent();
            BringToFront();
        }

        public async Task LadeNutzer(int nutzerId)
        {
            this.nutzerId = nutzerId;
            Nutzer n = await Task.Run(() => Form1.client.LadeNutzer(nutzerId));

            nameLb.Text = n.BenutzerName;
            abonnentenLb.Text = $"Abonnenten: {n.AbonnentenAnzahl}";
            byte[] pictureBytes = Convert.FromBase64String(n.ProfilBild);
            using (MemoryStream ms = new MemoryStream(pictureBytes))
            {
                nutzerPb.Image = Image.FromStream(ms);
            }
        }

        private async void abonnierenBtn_Click(object sender, EventArgs e)
        {
            string reply = Form1.client.Abonnieren(nutzerId);
            await LadeNutzer(nutzerId);
            MessageBox.Show(reply);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
