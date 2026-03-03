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
    public partial class Inhalte : UserControl
    {
        public List<string> pictures;
        public string titel;
        public List<Image> anzeigeBilder = new List<Image>();
        private int scrollIndex = 0;
        private int beitragId;
        private Beitrag beitrag;
        //public Inhalte(List<string> pictures, string titel, int beitragId)
        //{
        //    InitializeComponent();
        //    pictures = new List<string>();
        //    this.pictures = pictures;
        //    this.titel = titel;
        //    this.beitragId = beitragId;
        //    setDaten(titel, pictures);
        //}
        public Inhalte(Beitrag beitrag)
        {
            InitializeComponent();
            pictures = new List<string>();
            this.beitrag = beitrag;
            this.pictures = new List<string>();
            this.titel = beitrag.Titel;
            this.beitragId = beitrag.Id;
            setDaten(titel, pictures);
        }

        public void setDaten(string titel, List<string> bilder) 
        {
            this.beitragTitel.Text = titel;
            likesLb.Text = $"Anzahl Likes: {this.beitrag.gebeAnzahlLikes()}";
            if (bilder.Count != 0)
            {
                konvertiereBilder(bilder);
                this.beitragBild.BackgroundImage = anzeigeBilder[0];
            }
            if (anzeigeBilder.Count == 1)
            {
                next.Visible = false;
            }
        }

        public void konvertiereBilder(List<string> bilder)
        {

            foreach (string str in bilder)
            {
                byte[] imageBytes = Convert.FromBase64String(str);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image img = Image.FromStream(ms);
                    anzeigeBilder.Add(new Bitmap(img));
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (scrollIndex == anzeigeBilder.Count - 1)
            {
                next.Visible = false;
                return;
            }
            else
            {
                last.Visible = true;
                scrollIndex++;
                this.beitragBild.BackgroundImage = anzeigeBilder[scrollIndex];
            }
            if (scrollIndex == anzeigeBilder.Count - 1)
                next.Visible = false;
        }

        private void last_Click(object sender, EventArgs e)
        {
            if(scrollIndex == 0) 
            {
                last.Visible = false;
                return;
            }
            else 
            {
                next.Visible = true;
                scrollIndex--;
                this.beitragBild.BackgroundImage = anzeigeBilder[scrollIndex];
            }
            if (scrollIndex == 0)
                last.Visible = false;
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            string reply = Form1.client.Like(beitragId);
            string[] parts = reply.Split(';');
            MessageBox.Show(parts[1]);
            if (parts[0] == "+")
                likesLb.Text = $"Anzahl Likes: {this.beitrag.gebeAnzahlLikes() + 1}";
        }
    }
}
