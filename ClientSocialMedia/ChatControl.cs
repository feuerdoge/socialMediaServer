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
    public partial class ChatControl : UserControl
    {
        public Action<int> ChatSelected;
        public ChatControl()
        {
            InitializeComponent();
            LoadChat();
        }
        private void LoadChat()
        {
            chatPanel.Controls.Clear();
            List<int> chats = Form1.client.LadeChats();
            for (int i = 1; i <= chats.Count; i++)
            {
                Button b = new Button();
                b.Text = $"Chat {i}";
                b.Width = 50;
                b.Tag = chats[i];
                b.Click += (s, e) =>
                {
                    ChatSelected?.Invoke(Convert.ToInt32(b.Tag));
                };
                chatPanel.Controls.Add(b);
            }
        }
    }
}
