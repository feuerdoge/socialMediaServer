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
    public partial class ChatItemControl : UserControl
    {
        public Action<int> ChatClicked;

        private int chatId;
        public ChatItemControl(Chat chat)
        {
            InitializeComponent();
            chatId = chat.ChatId;
            nameLb.Text = chat.BenutzerName;
            lastLb.Text = $"Last:'{chat.LetzteNachricht}'";
            dateLb.Text = $"Von: {chat.LetzteZeit.ToString("g")}";

            byte[] bytes = Convert.FromBase64String(chat.ProfilBild);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                profilPic.Image = img;
            }
            this.Click += ChatItem_Click;
            foreach(Control c in this.Controls)
            {
                c.Click += ChatItem_Click;
            }
        }

        private void ChatItem_Click(object sender, EventArgs e)
        {
            ChatClicked?.Invoke(chatId);
        }

        private void ChatItem_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            this.BackColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ChatItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.None;
        }
    }
}
