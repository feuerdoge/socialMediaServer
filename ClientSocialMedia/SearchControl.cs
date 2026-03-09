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
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        private async void searchTb_TextChanged(object sender, EventArgs e)
        {
            overviewPanel.Visible = false;
            resultPanel.Visible = true;
            if (searchTb.Text.Length < 3)
            {
                resultPanel.Controls.Clear();
                return;
            }
            await Suche(searchTb.Text);
        }

        private async Task Suche(string name)
        {
            resultPanel.Controls.Clear();

            List<Nutzer> nutzer = await Task.Run(() => Form1.client.SucheNutzer(name));
            foreach (Nutzer n in nutzer)
            {
                UserSearchResultControl u = new UserSearchResultControl();
                u.Load(n);
                u.OnUserClick += OpenUserOverview;

                resultPanel.Controls.Add(u);
            }

        }

        private async void OnUserOvererviewClose()
        {
            overviewPanel.Visible = false;
            resultPanel.Visible = true;
            if (searchTb.Text.Length < 3)
                return;
            await Suche(searchTb.Text);
        }

        public void OpenUserOverview(Nutzer n)
        {
            resultPanel.Visible = false;
            overviewPanel.Controls.Clear();
            overviewPanel.Visible = true;
            UserOverviewControl u = new UserOverviewControl();
            u.OnClose += OnUserOvererviewClose;
            u.OnChatCreated += ShowChat;   
            u.LadeNutzer(n);
            overviewPanel.Controls.Add(u);
        }
        private void ShowChat(ChatOverviewControl coc)
        {
            this.Controls.Clear();
            this.Controls.Add(coc);
        }
    }
}
