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
using System.Xml.Linq;

namespace ClientSocialMedia
{
    public partial class UserSearchResultControl : UserControl
    {
        private Nutzer nutzer;
        public Action<Nutzer> OnUserClick;
        public UserSearchResultControl()
        {
            InitializeComponent();
        }

        public void Load(Nutzer n)
        {
            this.nutzer = n;
            nameLb.Text = n.BenutzerName;
            byte[] bytes = Convert.FromBase64String(n.ProfilBild);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                profilPic.Image = img;
            }
        }

        private void UserSearchResultControl_Click(object sender, EventArgs e)
        {

            OnUserClick?.Invoke(nutzer);
        }

        private void UserSearchResultControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Cursor = Cursors.Hand;
        }

        private void UserSearchResultControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Cursor = Cursors.Default;
        }
    }
}
