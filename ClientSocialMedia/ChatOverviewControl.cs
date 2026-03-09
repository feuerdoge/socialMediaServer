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
    public partial class ChatOverviewControl : UserControl
    {
        private int chatId;
        private List<Nachricht> nachrichten;
        public ChatOverviewControl(int chat)
        {
            InitializeComponent();
            this.chatId = chat;
            this.nachrichten = new List<Nachricht>();
        }

        public async void LoadNachrichten()
        {
            messagesPanel.Controls.Clear();
            nachrichten = await Task.Run(() => Form1.client.LadeNachrichten(this.chatId));
            foreach (Nachricht n in nachrichten)
            {
                MessageControl m = new MessageControl(n);
                m.Margin = new Padding(0, 0, 0, 10);
                messagesPanel.Controls.Add(m);
                messagesPanel.ScrollControlIntoView(m);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string text = messageTb.Text.Trim();
            if (string.IsNullOrEmpty(text))
                return;
            Form1.client.SendeNachricht(chatId, text);
            messageTb.Text = "";
            LoadNachrichten();
        }
    }
}
