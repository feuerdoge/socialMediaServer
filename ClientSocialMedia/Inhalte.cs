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
        public Inhalte(List<string> pictures, string titel)
        {
            InitializeComponent();
            pictures = new List<string>();
            this.pictures = pictures;
            this.titel = titel;
            setDaten(titel, pictures);
        }

        public void setDaten(string titel, List<string> bilder) 
        {
            this.beitragTitel.Text = titel;
            if (bilder.Count != 0)
            {
                konvertiereBilder(bilder);
                this.beitragBild.BackgroundImage = anzeigeBilder[0];
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
            if (scrollIndex == anzeigeBilder.Count)
            {
                next.Visible = false;
                return;
            }
            else
            {
                scrollIndex++;
                this.beitragBild.BackgroundImage = anzeigeBilder[scrollIndex];
            }
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
                scrollIndex--;
                this.beitragBild.BackgroundImage = anzeigeBilder[scrollIndex];
            }
            if (scrollIndex != anzeigeBilder.Count)
            {
                next.Visible = true;
            }
            scrollIndex--;
        }
    }
}
