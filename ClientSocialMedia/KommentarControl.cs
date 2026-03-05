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
    public partial class KommentarControl : UserControl
    {
        private string benutzer;
        private string text;
        private Kommentar kommentar;

        public KommentarControl(string nutzer, string text, Kommentar kommentar)
        {
            InitializeComponent();
            setKommentar(nutzer, text, kommentar);
        }

        public void setKommentar(string nutzer, string text, Kommentar kommentar) 
        {
            this.text = text;
            this.komm.Text = this.text;

            this.benutzer = nutzer;

            this.autor.Text = benutzer;
            this.profil.Image = Inhalte.konvertiereBild(kommentar.profil);
        }
    }
}
