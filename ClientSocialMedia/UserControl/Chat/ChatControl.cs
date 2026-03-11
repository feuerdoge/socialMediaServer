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
            List<Chat> chats = Form1.client.LadeChats();
            foreach (Chat chat in chats)
            {
                ChatItemControl cic = new ChatItemControl(chat);
                cic.Width = chatPanel.Width - 10;
                cic.ChatClicked += ChatClicked;
                chatPanel.Controls.Add(cic);
            }
        }

        private void ChatClicked(int chatId)
        {
            ChatSelected?.Invoke(chatId);
        }
    }
}
