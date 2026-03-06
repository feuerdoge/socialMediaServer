using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using socialMediaServer;
using SocketAbi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClientSocialMedia
{
    public class Client
    {
        public SocketAbi.Socket clientSocket;
        private string benutzername;
        public Client()
        {
            //IPAddress adress = IPAddress.Parse("10.1.2.186");
            this.clientSocket = new SocketAbi.Socket("localhost", 5555);
            Verbinden();
        }

        public bool Verbinden() 
        {
            bool status = clientSocket.Connect();
            return status;
        }
        public string anmelden(string benutzername, string passwort) 
        {
            string eingabe = $"{benutzername};{passwort}";
            clientSocket.Write("anmelden;" + eingabe +'\n');
            string msg = clientSocket.ReadLine();
            this.benutzername = benutzername;
            MessageBox.Show(msg);
            return msg;
            //List<string> bilder = BilderAuswaehlen();
            //msg = $"beitrag;Hallo Welt;{bilder.Count}";
            //clientSocket.Write($"{msg}{PictureMessage(bilder)};Wow das ist ja ein cooler Beitrag!\n");
            //MessageBox.Show(clientSocket.ReadLine());
        }

        public void registrieren(string benutzername, string passwort, string email) 
        {
            string eingabe = $"{benutzername};{passwort};{email}";
            clientSocket.Write("registrieren;"+eingabe+'\n');
            string msg = clientSocket.ReadLine();
            MessageBox.Show(msg);
            //clientSocket.Write("registrieren;" + eingabe + ";test1233@gmx.de" +'\n');  // Registrieren
            //MessageBox.Show(clientSocket.ReadLine());
            //clientSocket.Write("anmelden;" + eingabe + '\n');
            //MessageBox.Show(clientSocket.ReadLine());
            //List<string> bilder = BilderAuswaehlen();  // Beitrag erstellen mit max 10 Bildern
            //string msg = $"beitrag;Hallo Welt;{bilder.Count};";
            //clientSocket.Write($"{PictureMessage(bilder)}Wow das ist ja was verrücktes!\n");
            //MessageBox.Show(clientSocket.ReadLine());
            //clientSocket.Write("neueBeitraege\n");
            //Test(clientSocket.ReadLine());
        }

        // Todo: Titel Test; Sämtliche Daten teilen
        public void BeitraegeAuspacken(string msg)
        {
            string titel = "";
            string[] parts = msg.Split(';');
            int anzahl = int.Parse(parts[1]);
            for (int i = 0; i < anzahl; i++)
            {
                string beitragString = parts[2 + i];
                string[] felder = beitragString.Split('|');
                titel += felder[1];
            }
            MessageBox.Show(titel);
        }
        public string PictureMessage(List<string> bilder)
        {
            string msg = "";
            foreach (string bild in bilder)
                msg += bild;
            return msg;
        }
        /// <summary>
        /// Opens a dialog lets the user select pictures and encodes them to base64 (bytes just as strings) 
        /// Adds them to a list with their filename.
        /// </summary>
        public static List<string> BilderAuswaehlen()
        {
            List<string> bilder = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bilder auswählen";
            dialog.Filter = "Bilder (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string path in dialog.FileNames)
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(path);  // Credits: https://stackoverflow.com/questions/1497997/reliable-way-to-convert-a-file-to-a-byte
                    string picture = Convert.ToBase64String(bytes);
                    string msg = $";{System.IO.Path.GetFileName(path)}|{picture}";
                    bilder.Add(msg);
                }
            }
            return bilder;
        }
        public void beitragSenden(string titel, List<string> bilder) 
        {
            string eingabe = $"{titel};{bilder.Count}";
            foreach (string bild in bilder) 
            {
                eingabe += bild;
            } 
            
            clientSocket.Write("beitrag;" + eingabe + '\n');
        }

        public string Like(int beitragId)
        {
            string msg = $"like;{beitragId}\n";
            clientSocket.Write(msg);
            return clientSocket.ReadLine();
        }

        public string Abonnieren(int abonnentId)
        {
            string msg = $"abonnieren;{abonnentId}\n";
            clientSocket.Write(msg);
            return clientSocket.ReadLine();
        }

        public int GetAbonnentenAnzahl(int nutzerId)
        {
            string msg = $"abonnentenAnzahl;{nutzerId}\n";
            clientSocket.Write(msg);
            string reply = clientSocket.ReadLine();
            if (reply.Trim(';')[0] == '+')
            {
                return Convert.ToInt32(reply.Split(';')[1]);
            }
            else
                return 0;
        }

        public void ErstelleKommentar(int beitragId, string nachricht, int? oberKommentarId)
        {
            string msg = $"kommentar;{beitragId};{nachricht}";
            clientSocket.Write(msg + "\n");
            string reply = clientSocket.ReadLine();
            MessageBox.Show(reply);
        }

        public List<Kommentar> LadeKommentare(int beitragId)
        {
            string msg = $"ladeKommentare;{beitragId}\n";
            clientSocket.Write(msg);
            string data = clientSocket.ReadLine();
            string[] parts = data.Split(';');
            if (parts[0] != "kommentare")
                return null;
            int anzahl = Convert.ToInt32(parts[1]);
            List<Kommentar> comments = new List<Kommentar>();
            
            for (int i = 0; i < anzahl; i++)
            {
                string[] commentData = parts[2 + i].Split('|');
                int id = Convert.ToInt32(commentData[0]);
                string nachricht = commentData[1];
                int autor = Convert.ToInt32(commentData[2]);
                DateTime timestamp = Convert.ToDateTime(commentData[3]);
                string autorKommentar = commentData[4];
                string profilAutor = commentData[5];
                string oberKommentar = commentData[6];
                Kommentar k;
                if (oberKommentar == "null") 
                {
                    k = new Kommentar(nachricht, timestamp, autor);
                }
                else
                {
                    k = new Kommentar(nachricht, timestamp, autor);
                }
                k.autor = autorKommentar;
                k.profil = profilAutor;
                comments.Add(k);
            }
            return comments;
        }
        public List<Beitrag> beitraegeAnfragen()
        {
            clientSocket.Write("neueBeitraege\n");
            string str;
            str = clientSocket.ReadLine();
            if(str == "neueBeitaege?0?") 
            {
                return null;
            }
            // Protokoll: neueBeitraege?anzahlBeitraege?id|titel|text|autor|anzahlLikes|timestamp|dateinamen1:bild1,dateinamen2:bild2,..,dateinamenN:bildn;...
            List<Beitrag> beitraege = new List<Beitrag>();
            if(str == null) 
            {
                return null;
            }
            string[] dataReceived = str.Split(';');
            string[] dataDetails = dataReceived[0].Split('?');
            foreach (string s in dataReceived) 
            {
                if(string.IsNullOrWhiteSpace(s))
                {
                    continue;

                }
                string[] relevantData = s.Split('|');
                string[] newRelevant = relevantData[0].Split('?');
                int id = Convert.ToInt32(newRelevant[2]);
                string titel = relevantData[1];
                string text = relevantData[2];
                int autor = Convert.ToInt32(relevantData[3]);
                List<Bild> bilder = new List<Bild>();
                int likes = Convert.ToInt32(relevantData[4]);
                DateTime timestamp = Convert.ToDateTime(relevantData[5]);
                string[] images = relevantData[6].Split(',');

                foreach (string image in images)
                {
                    string[] innerData = image.Split(':');
                    if (innerData.Length == 2)
                    {
                        string imageName = innerData[0];
                        string imageData = innerData[1];
                        byte[] imageBytes = Convert.FromBase64String(imageData);
                        File.WriteAllBytes(imageName, imageBytes);
                        Bild bild = new Bild(imageName);
                        bild.bilddata = imageData;
                        bilder.Add(bild);
                    }
                }
                Beitrag b = new Beitrag(new Nutzer("Nutzer", "", "", autor), titel, bilder);
                b.Id = id;
                b.setAnzahlLikes(likes);
                b.setGeposted(timestamp);
                if (!string.IsNullOrEmpty(text))
                    b.ErstelleText(text);
                beitraege.Add(b);
            }
            
            return beitraege;
        }
        
        public Nutzer LadeProfil()
        {
            clientSocket.Write("loadProfile\n");
            string msg = clientSocket.ReadLine();
            string[] parts = msg.Split(';');
            string name = parts[1];
            string email = parts[2];
            int id = Convert.ToInt32(parts[3]);
            DateTime zuletztAktiv = Convert.ToDateTime(parts[4]);
            int abonnenten = Convert.ToInt32(parts[5]);
            Nutzer n = new Nutzer(name, "", email, id);
            n.ZuletztAktiv = zuletztAktiv;
            n.AbonnentenAnzahl = abonnenten;
            string base64 = parts[6];
            n.ProfilBild = base64;
            

            return n;
        }

        public byte[] LadeProfilePicture()
        {
            clientSocket.Write("loadProfile\n");
            string msg = clientSocket.ReadLine();
            string[] parts = msg.Split(';');
            string base64 = parts[6];
            return Convert.FromBase64String(base64);
        }

        public string ProfilAktualisieren(string name, string email)
        {
            string msg = $"updateProfile;{name};{email}\n";
            clientSocket.Write(msg);
            return clientSocket.ReadLine();
        }

        public string ProfilBild(string fileName, string picture)
        {
            string msg = $"addProfilePicture;{fileName};{picture}\n";
            clientSocket.Write(msg);
            return clientSocket.ReadLine();
        }

        public string PasswortAktualisieren(string old, string newP)
        {
            string msg = $"updatePasswort;{old};{newP}\n";
            clientSocket.Write(msg);
            return clientSocket.ReadLine();
        }

        public List<Beitrag> sortiereBeitraegeNachBeliebtheit(List<Beitrag> beitraege, int left, int right) 
        {

            int i = left;
            int x = right - 1;
            var pivot = beitraege[right];
            
            while(i < x) 
            {
                if (beitraege[i].gebeAnzahlLikes() < pivot.gebeAnzahlLikes()) 
                {
                    i++;
                }
                if (beitraege[x].gebeAnzahlLikes() > pivot.gebeAnzahlLikes()) 
                {
                    x--;
                }
                if (beitraege[i].gebeAnzahlLikes() > pivot.gebeAnzahlLikes() && beitraege[x].gebeAnzahlLikes() < pivot.gebeAnzahlLikes()) 
                {
                    var temp = beitraege[i];
                    beitraege[i] = beitraege[x];
                    beitraege[x] = temp;

                    i++;
                    x--;
                }
            }

            if (beitraege[i].gebeAnzahlLikes() > pivot.gebeAnzahlLikes()) 
            {
                beitraege[right] = beitraege[i];
                beitraege[i] = pivot;
            }

            left += i + 1;

            if(left < right) 
            {
                beitraege = sortiereBeitraegeNachBeliebtheit(beitraege, left, right);
            }
            else 
            {
                left = 0;
                if(right == 0) 
                {
                    return beitraege;
                }
                beitraege = sortiereBeitraegeNachBeliebtheit(beitraege, left, right - 1);
            }
            return beitraege;
            
        }
    }
}
