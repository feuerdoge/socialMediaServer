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
    }
}
