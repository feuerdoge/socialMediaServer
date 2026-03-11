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
    public partial class MessageControl : UserControl
    {
        private Nachricht nachricht;
        public MessageControl(Nachricht nachricht)
        {
            InitializeComponent();
            this.nachricht = nachricht;
            LoadMessage();
        }

        private void LoadMessage()
        {
            nameLb.Text = nachricht.Sender.BenutzerName;
            if (nachricht.Text == null)
                text.Text = "Noch keine Nachricht!";
            else
                text.Text = nachricht.Text;
            Size textSize = TextRenderer.MeasureText(nachricht.Text, text.Font, new Size(text.Size.Width, text.Size.Height), TextFormatFlags.WordBreak);
            text.Size = new Size(textSize.Width + 10, textSize.Height + 5);
            int lineCount = text.GetLineFromCharIndex(text.TextLength) + 1;
            int lineHeight = TextRenderer.MeasureText("A", text.Font).Height;
            if (lineCount <= 5)
            {
                text.Height = lineHeight * lineCount + 6;
                text.ScrollBars = RichTextBoxScrollBars.None;
            }
            else
            {
                text.Height = lineHeight * 5 + 6;
                text.ScrollBars = RichTextBoxScrollBars.Vertical;
            }

            if (nachricht.GesendetAm == null)
                dateLb.Hide();
            else
                dateLb.Text = $"Gesendet: {nachricht.GesendetAm.ToString("g")}";
            byte[] bytes = Convert.FromBase64String(nachricht.Sender.ProfilBild);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                profilePic.Image = img;
            }
            this.Height = text.Height + 20;
        }
    }
}
