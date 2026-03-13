using socialMediaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocialMedia
{
    public partial class Form1 : Form
    {
        private TextBox tbNutzername;
        private TextBox tbPasswort;
        private TextBox titelEingabe;
        private Panel panel;
        private Button registrieren;
        private Button anmeldeButton;
        private TextBox email;
        private bool registerToggle = false;
        public List<string> bilder = new List<string>();
        private List<Beitrag> beitraege = new List<Beitrag>();
        private Button loadMoreBtn = new Button();
        public static Client client = new Client();
        private int beitragOffset = 0;
        
        public Form1()
        {
            InitializeComponent();
            ErstellePanel();
        }

        public void UpdateProfilePicture()
        {
            byte[] profileBytes = client.LadeProfilePicture();
            using (MemoryStream ms = new MemoryStream(profileBytes))
            {
                Image img = Image.FromStream(ms);
                profilePic.Image = img;
            }
            profilePic.BringToFront();
        }
        public void ErstellePanel()
        {
            panel = new Panel();
            panel.Left = (this.ClientSize.Width - panel.Width + 50) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height - 20) / 2;
            panel.Width = this.Width;
            panel.Height = this.Height;
            this.Controls.Add(panel);

            Label anmelden = new Label()
            {
                Width = 150,
                Height = 15,
                Text = "Anmelden"
                
            };
            panel.Controls.Add(anmelden);

            tbNutzername = new TextBox()
            {
                Width = 150,
                Height = 15,
                Location = new Point(0, anmelden.Location.Y + 20),
                Text = "Benutzername...",
                
                
            };
            tbPasswort = new TextBox()
            {
                Width = 150,
                Height = 15,
                Location = new Point(0, anmelden.Location.Y + 40),
                Text = "Passwort..."
            };
            panel.Controls.Add(tbNutzername);
            panel.Controls.Add(tbPasswort);

            tbNutzername.Click += tbNutzername_Click;
            tbPasswort.Click += tbPasswort_Click;

            anmeldeButton = new Button()
            {
                Size = new Size(150, 25),
                Location = new Point(0, anmelden.Location.Y + 60),
                BackColor = Color.White,
                Text = "Anmelden"
            };
            registrieren = new Button()
            {
                Size = new Size(150, 25),
                Location = new Point(0, anmelden.Location.Y + 85),
                BackColor = Color.White,
                Text = "Noch kein Nutzer?"
            };
            email = new TextBox()
            {
                Visible = false,
                Width = 150,
                Height = 15,
                Location = new Point(0, anmelden.Location.Y + 60),
                Text = "Email Eingeben"
            };
            email.Click += email_Click;
            panel.Controls.Add(anmeldeButton);
            panel.Controls.Add(registrieren);
            panel.Controls.Add(email);
            if(!registerToggle) 
            {
                anmeldeButton.Click += anmeldeButton_Click;
                registrieren.Click += registrieren_Click;
            }
            else if(registerToggle) 
            {
                anmeldeButton.Click += anmeldeButton_Click;
            } 
                    
        }

        private void zeigeProgram() 
        {
            menuPanel.BackColor = Color.White;
            Button buttonBeitraege = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 10),
                BackColor = Color.White,
                Text = "Beiträge"
            };
            Button buttonBeliebt = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 70),
                BackColor = Color.White,
                Text = "Beliebt"
            };
            Button buttonNurAbos = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 130),
                BackColor = Color.White,
                Text = "Beiträge Abonnierter Nutzer"
            };
            Button buttonErstellen = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 190),
                BackColor= Color.White,
                Text = "Beitrag Erstellen"
            };
            Button empfehlungen = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 250),
                BackColor = Color.White,
                Text = "Empfehlungen"
            };
            Button buttonChat = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 310),
                BackColor = Color.White,
                Text = "Chat"
            };
            Button buttonGruppen = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 370),
                BackColor = Color.White,
                Text = "Gruppen"
            };
            Button buttonSuchen = new Button()
            {
                Size = new Size(215, 60),
                Location = new Point(10, 430),
                BackColor = Color.White,
                Text = "Suchen"
            };

            loadMoreBtn = new Button()
            {
                Text = "Weitere Beiträge laden",
                Width = 200,
                Height = 40,
            };
            loadMoreBtn.Click += LoadMoreBtn_Click;


            buttonErstellen.Click += erstellen_Click;
            buttonChat.Click += Chat_Click;
            buttonSuchen.Click += Suche_Click;
            menuPanel.Controls.Add(buttonBeitraege);
            menuPanel.Controls.Add(buttonBeliebt);
            menuPanel.Controls.Add(buttonNurAbos);
            menuPanel.Controls.Add(empfehlungen);
            menuPanel.Controls.Add(buttonErstellen);
            menuPanel.Controls.Add(buttonChat);
            menuPanel.Controls.Add(buttonGruppen);
            menuPanel.Controls.Add(buttonSuchen);

            buttonBeitraege.Click += buttonBeitraege_Click;
            buttonBeliebt.Click += buttonBeliebt_Click;
            buttonNurAbos.Click += buttonNurAbos_Click;
            empfehlungen.Click += empfehlungen_Click;
            

            zeigeInhalte();
        }

        private void buttonBeitraege_Click(object sender, EventArgs e)
        {
            zeigeInhalte();
        }

        private void zeigeInhalte() 
        {
            Cursor = Cursors.WaitCursor;
            UpdateProfilePicture();
            EmpfangeDaten();
            inhaltAnzeige.Enabled = true;
            inhaltAnzeige.Visible = true;
            menuPanel.Visible = true;
            Cursor = Cursors.Default;
        }
        private async void EmpfangeDaten() 
        {
            beitragOffset = 0;
            inhaltAnzeige.Controls.Clear();
            beitraege = await Task.Run(() => client.beitraegeAnfragen(false, false, false, beitragOffset));
            if(beitraege == null) 
            {
                return;
            }
            foreach(Beitrag beitraege in beitraege) 
            {
                Inhalte inhalt = new Inhalte(beitraege);

                
                inhaltAnzeige.Controls.Add(inhalt);
            }
            beitragOffset = beitraege.Count;
            loadMoreBtn.Tag = "neue";
            inhaltAnzeige.Controls.Add(loadMoreBtn);
            //Server nach einer Liste aller Beiträge fragen
            //Diese Liste wird interpretiert, d.h das jedes Element dieser Liste von Beiträgen in ein Inhalt gewandelt wird.
            //Diese Inhalte werden auf den FlowLayoutPanel geladen. (inhaltAnzeige.Controls.Add(inhalt))
        }

        private async void LoadMoreBtn_Click(object sender, EventArgs e)
        {
            loadMoreBtn.Enabled = false;
            loadMoreBtn.Text = "Lade...";
            List<Beitrag> neue = new List<Beitrag>();
            if (loadMoreBtn.Tag == "abos")
                neue = await Task.Run(() => client.beitraegeAnfragen(true, false, false,beitragOffset));
            else if (loadMoreBtn.Tag == "neue")
                neue = await Task.Run(() => client.beitraegeAnfragen(false, false, false,beitragOffset));
            if (neue != null)
            {
                foreach (Beitrag b in neue)
                {
                    Inhalte inhalt = new Inhalte(b);
                    int index = inhaltAnzeige.Controls.IndexOf(loadMoreBtn);
                    inhaltAnzeige.Controls.Add(inhalt);
                    inhaltAnzeige.Controls.SetChildIndex(inhalt, index);
                }
            }
            beitragOffset += neue.Count;
            loadMoreBtn.Text = "Weitere Beiträge laden";
            loadMoreBtn.Enabled = true;
            if (neue.Count == 0)
            {
                loadMoreBtn.Text = "Keine weiteren Beiträge vorhanden";
            }
        }

        private void refresh() 
        {
            
        }
        private void tbNutzername_Click(object sender, EventArgs e) 
        {
            TextBox t = (TextBox)sender;

            t.Text = "";
        }

        private void tbPasswort_Click(object sender, EventArgs e) 
        {
            TextBox t = (TextBox)sender;

            t.Text = "";
        }
        private void email_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            t.Text = "";
        }
        private void anmeldeButton_Click(object sender, EventArgs e) 
        {
            if(!registerToggle) 
            {
                string antwort = client.anmelden(tbNutzername.Text, tbPasswort.Text);
                if (antwort.Contains("+")) 
                {
                    panel.Hide();
                    profilePic.Visible = true;
                    zeigeProgram();
                }
            }
            if(registerToggle) 
            {
                NutzerRegistrieren();
            
            }
        }
        private void registrieren_Click(object sender, EventArgs e) 
        {
            if(!registerToggle) 
            {
                tbNutzername.Text = "Nutzername...";
                tbPasswort.Text = "Passwort festlegen...";
                registrieren.Text = "Anmelden";
                anmeldeButton.Text = "Registrieren";
                email.Visible = true;
                registrieren.Location = new Point(registrieren.Location.X, registrieren.Location.Y + 20);
                anmeldeButton.Location = new Point(anmeldeButton.Location.X, anmeldeButton.Location.Y + 20);
                registerToggle = true;
            }
            else 
            {
                tbNutzername.Text = "Benutzername...";
                tbPasswort.Text = "Passwort...";
                registrieren.Text = "Noch kein Nutzer?";
                anmeldeButton.Text = "Anmelden";
                registrieren.Location = new Point(registrieren.Location.X, registrieren.Location.Y - 20);
                anmeldeButton.Location = new Point(anmeldeButton.Location.X, anmeldeButton.Location.Y - 20);
                registerToggle = false;
            }
            
        }

        private void NutzerRegistrieren() 
        {
            client.registrieren(tbNutzername.Text, tbPasswort.Text, email.Text);
        }

        private void bildauswaehlen_OnClick(object sender, EventArgs e) 
        {
            bilder = Client.BilderAuswaehlen();
        }

        private void erstellen_Click(object sender, EventArgs e)
        {
            if (beitragsErstellungsPanel.Visible)
            {
                beitragsErstellungsPanel.Visible = false;
                return;
            }
            beitragsErstellungsPanel.Controls.Clear();
            beitragsErstellungsPanel.Controls.Add(this.tagPick);
            beitragsErstellungsPanel.Controls.Add(this.tagLabel);
            beitragsErstellungsPanel.Visible = true;
            tagPick.Items.Clear();
            tagPick.Visible = true;
            tagPick.Items.AddRange(new string[] {
                "Tiere",
                "Memes",
                "Sonstiges",
                "News"
            });
            inhaltAnzeige.Show();

            titelEingabe = new TextBox();
            beitragsErstellungsPanel.Controls.Add(titelEingabe);
            titelEingabe.Location = new Point(titelEingabe.Location.X + 10, titelEingabe.Location.Y + 10);

            bilder = new List<string>();

            Button bildauswaehlen = new Button();
            bildauswaehlen.Location = new Point(bildauswaehlen.Location.X + 10, bildauswaehlen.Location.Y + 40);
            bildauswaehlen.Width = 100;
            bildauswaehlen.Height = 25;
            bildauswaehlen.Text = "Bild auswählen";
            beitragsErstellungsPanel.Controls.Add(bildauswaehlen);
            bildauswaehlen.Click += bildauswaehlen_OnClick;

            Button beitragErstellen = new Button();
            beitragErstellen.Location = new Point(bildauswaehlen.Location.X, bildauswaehlen.Location.Y + 70);
            beitragErstellen.Width = 100;
            beitragErstellen.Height = 25;
            beitragErstellen.Text = "Beitrag erstellen";
            beitragsErstellungsPanel.Controls.Add(beitragErstellen);

            Button closeBtn = new Button()
            {
                Width = 50,
                Height = 20,
                Text = "Close",
                Location = new Point(beitragsErstellungsPanel.Width - 70, titelEingabe.Location.Y)
            };
            closeBtn.Click += (s, e2) =>
            {
                beitragsErstellungsPanel.Visible = false;
            };
            beitragsErstellungsPanel.Controls.Add(closeBtn);

            beitragsErstellungsPanel.BringToFront();

            tagPick.Visible = true;
            tagPick.BringToFront();
            beitragsErstellungsPanel.Controls.Add(tagPick);
            beitragErstellen.Click += beitragErstellen_Click;
        }

        private void beitragErstellen_Click(object sender, EventArgs e) 
        {
            if(tagPick.Text == "") 
            {
                MessageBox.Show("Wähle ein Tag aus!");
                return;
            }
            tagPick.Visible = false;
            client.beitragSenden(titelEingabe.Text, bilder, tagPick.Text);
            beitragsErstellungsPanel.Visible = false;
            EmpfangeDaten();
        }
        
        public void Abmelden()
        {
            inhaltAnzeige.Controls.Clear();
            inhaltAnzeige.Visible = false;
            profilePic.Visible = false;
            menuPanel.Visible = false;
            profilePic.Tag = null;
            ErstellePanel();
        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            inhaltAnzeige.Controls.Clear();
            ProfileControl profil = new ProfileControl();
            profil.OnProfileChange = (img) =>
            {
                profilePic.Image = img;
            };
            profil.OnAbmelden = () =>
            {
                Abmelden();
            };
            profil.OnClose = () =>
            {
                inhaltAnzeige.Controls.Clear();
                zeigeInhalte();
            };
            inhaltAnzeige.Controls.Add(profil);            
        }

        private void profilePic_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 250;
            tt.SetToolTip(profilePic, "Profil anpassen");
            Cursor = Cursors.Hand;
            profilePic.BackColor = Color.FromArgb(230, 230, 230);
            profilePic.Size = new Size(54, 54);
        }

        private void profilePic_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            profilePic.Size = new Size(50, 50);
        }

        private void buttonBeliebt_Click(object sender, EventArgs e) 
        {
            beitraege = client.beitraegeAnfragen(false, false, true, beitragOffset);
            if (beitraege == null)
            {
                return;
            }
            beitragOffset += beitraege.Count;
            this.inhaltAnzeige.Controls.Clear();
            //beitraege = client.sortiereBeitraegeNachBeliebtheit(beitraege, 0, beitraege.Count - 1);
            
            for(int i = beitraege.Count - 1; i > -1; i--) 
            {
                Inhalte inhalt = new Inhalte(beitraege[i]);
                inhaltAnzeige.Controls.Add(inhalt);
            }
        }

        private void buttonNurAbos_Click(object sender, EventArgs e) 
        {
            inhaltAnzeige.Controls.Clear();
            beitraege = client.beitraegeAnfragen(true, false, false, beitragOffset);
            if (beitraege == null)
            {
                return;
            }
            foreach (Beitrag beitraege in beitraege)
            {
                Inhalte inhalt = new Inhalte(beitraege);


                inhaltAnzeige.Controls.Add(inhalt);
            }
            beitragOffset = beitraege.Count;
            loadMoreBtn.Tag = "abos";
            inhaltAnzeige.Controls.Add(loadMoreBtn);
        }
        
        private async void empfehlungen_Click(object sender, EventArgs e) 
        {
            inhaltAnzeige.Controls.Clear();
            beitraege = await Task.Run(() => client.beitraegeAnfragen(false, true, false, beitragOffset));
            if (beitraege == null)
            {
                return;
            }
            foreach (Beitrag beitraege in beitraege)
            {
                Inhalte inhalt = new Inhalte(beitraege);


                inhaltAnzeige.Controls.Add(inhalt);
            }
            beitragOffset += beitraege.Count;
        }
        private void Suche_Click(object sender, EventArgs e)
        {
            inhaltAnzeige.Controls.Clear();
            SearchControl searchControl = new SearchControl();
            inhaltAnzeige.Controls.Add(searchControl);
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            ChatControl cc = new ChatControl();
            cc.ChatSelected += ChatControl_ChatSelected;
            inhaltAnzeige.Controls.Clear();
            inhaltAnzeige.Controls.Add(cc);
        }

        private async void ChatControl_ChatSelected(int chatId)
        {
            ChatOverviewControl coc = new ChatOverviewControl(chatId);
            inhaltAnzeige.Controls.Clear();
            inhaltAnzeige.Controls.Add(coc);
            coc.LoadNachrichten();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
