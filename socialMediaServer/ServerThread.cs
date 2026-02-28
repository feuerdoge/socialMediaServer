using SocketAbi;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace socialMediaServer
{
    public class ServerThread
    {
        private SocialMediaPlatform spf;
        public SocketAbi.Socket client;
        private Nutzer nutzer;
        private static string imgOrdner = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

        public ServerThread(SocketAbi.Socket cs) 
        {
            this.client = cs;
            spf = new SocialMediaPlatform();
        }

        public void HandleConnection()
        {
            Console.WriteLine("Client hat sich verbunden!");
            try
            {
                while (true)
                {
                    
                    string befehl = client.ReadLine();
                    Console.WriteLine($"Empfangen: {befehl}");

                    string[] parameter = befehl.Split(';');
                    if (parameter.Length == 0)
                        continue;
                    string command = parameter[0];
                    switch (command)
                    {
                        case "anmelden":
                            string name = parameter[1];
                            string password = parameter[2];
                            Nutzer nutzer = spf.Anmelden(name, password);
                            if (nutzer != null)
                            {
                                this.nutzer = nutzer;
                                client.Write("+;Willkommen\n");
                            }
                            else
                            {
                                client.Write("-;falscheAnmeldedaten\n");
                            }
                            break;
                        case "registrieren":
                            name = parameter[1];
                            password = parameter[2];
                            string email = parameter[3];
                            int code = spf.Registrieren(name, password, email);
                            if (code == -1)
                                client.Write("-;NameOrEmailVorhanden\n");
                            else
                                client.Write("+;registrierungerfolg\n");
                            break;
                        case "beitrag":
                            string titel = parameter[1];
                            int anzahl = Convert.ToInt32(parameter[2]);
                            if (anzahl > 10)
                            {
                                client.Write("-;fehler;max10\n");
                                break;
                            }
                            List<string> dateinamen = new List<string>();
                            for (int i = 0; i < anzahl; i++)
                            {
                                string[] pieces = parameter[3 + i].Split('|');
                                
                                if (pieces.Length != 2)
                                {
                                    Console.WriteLine("Bild fehlerhaft übertragen");
                                    client.Write("-;error while transmitting\n");
                                    continue;
                                }
                                string dateiname = pieces[0];

                                byte[] bytes = Convert.FromBase64String(pieces[1]);

                                string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(dateiname);
                                string pfad = Path.Combine(imgOrdner, uniqueName);

                                File.WriteAllBytes(pfad, bytes);

                                dateinamen.Add(uniqueName);
                            }
                            string text = null;
                            if (parameter.Length > 3 + anzahl)
                                text = parameter[3 + anzahl];
                                         
                            spf.ErstelleBeitrag(this.nutzer, titel, text, dateinamen);
                            //client.Write("+;Hochgeladen\n");
                            break;
                        case "neueBeitraege":
                            List<Beitrag> beitraege = spf.ErmittleNeueBeitraege(this.nutzer);
                            foreach(Beitrag b in beitraege)
                            {
                                foreach(Bild bild in spf.HoleBilder(b.Id))
                                {
                                    b.Hinzufuegen(bild);
                                }
                            }
                            // Protokoll: neueBeitraege.anzahlBeitraege.id|titel|text|autor|anzahlLikes|timestamp|dateinamen1:bild1,dateinamen2:bild2,..,dateinamenN:bildn;...
                            string msg = "";
                            if(beitraege.Count == 0) 
                            {
                                msg = $"neueBeitaege?{beitraege.Count}?";
                            }
                            foreach (Beitrag b in beitraege)
                            {
                                List<string> bilderStringList = new List<string>();
                                foreach(Bild img in b.Bilder)
                                {
                                    string s = Convert.ToBase64String(File.ReadAllBytes(Path.Combine("img", img.Dateiname)));
                                    bilderStringList.Add($"{img.Dateiname}:{s}");
                                }
                                string bilderString = string.Join(",", bilderStringList);
                                msg += $"neueBeitaege?{beitraege.Count}?{b.Id}|{b.Titel}|{b.Text}|{b.Autor.BenutzerName}|{b.gebeAnzahlLikes()}|{b.Geposted}|{bilderString}";
                                msg += ";";
                            }
                            
                            Console.WriteLine(msg);
                            client.Write(msg + "\n");
                            break;

                        case "like":   // like;2 (BeitragId)
                            int beitragId = Convert.ToInt32(parameter[1]);
                            int response = spf.Like(beitragId, this.nutzer.BenutzerId);
                            if (response == -1)
                            {
                                Console.WriteLine("Fehler beim liken");
                                client.Write("-;Autor kann nicht selbst liken\n");
                            }
                            else
                            {
                                client.Write("+;Liken Erfolgreich\n");
                            }
                            break;
                        case "abonnieren":
                            int abonnentId = Convert.ToInt32(parameter[1]);
                            response = spf.Abonnieren(this.nutzer.BenutzerId, abonnentId);
                            if (response == 0)
                            {
                                client.Write("+;Abonnent erfolgreich abonniert\n");
                            }
                            else if (response == 1)
                                client.Write("-;Nutzer kann sich nicht selbst abonnieren\n");
                            else
                                client.Write("-;Abonnent wurde bereits vom Nutzer abonniert\n");
                            break;
                        case "abonnentenAnzahl":
                            int nutzerId = Convert.ToInt32(parameter[1]);
                            anzahl = spf.ErmittelAbonnentenAnzahl(nutzerId);
                            Console.WriteLine($"Nutzer {nutzerId} hat {anzahl} Abonnenten");
                            client.Write($"+;{anzahl}\n");
                            break;
                        case "kommentar":
                            beitragId = Convert.ToInt32(parameter[1]);
                            text = parameter[2];
                            int? oberKommentarId = null;
                            if (parameter.Length > 3)
                                oberKommentarId = Convert.ToInt32(parameter[3]);
                            spf.ErstelleKommentar(beitragId, this.nutzer.BenutzerId, text, oberKommentarId);
                            client.Write("+;Kommentar erfolgreich erstellt\n");
                            break;
                        case "ladeKommentare":
                            beitragId = Convert.ToInt32(parameter[1]);
                            List<Kommentar> kommentare = spf.LadeKommentare(beitragId);
                            msg = $"kommentare;{kommentare.Count}";
                            foreach (Kommentar k in kommentare)
                            {
                                msg += $";{k.Id}|{k.Nachricht}|{k.AutorId}|{k.Timestamp}|";
                                if (k.OberKommentarId != null)
                                    msg += k.OberKommentarId;
                                else
                                    msg += "null";
                            }
                            client.Write(msg + "\n");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fehler: {e.Message}");
            }
            finally
            {
                client.Close();
                Console.WriteLine("Client getrennt.");
            }
        }
    }
}
