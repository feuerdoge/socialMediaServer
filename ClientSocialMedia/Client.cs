using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketAbi;

namespace ClientSocialMedia
{
    public class Client
    {
        public SocketAbi.Socket clientSocket;

        public Client()
        {
            //IPAddress adress = IPAddress.Parse("10.1.2.186");
            this.clientSocket = new SocketAbi.Socket("DESKTOP-6O3FLCA", 5555);
            Verbinden("10.1.2.186", 5555);
        }

        public bool Verbinden(string server, int port) 
        {
            bool status = clientSocket.Connect();
            return status;
        }
        public void anmelden(string benutzername, string passwort) 
        {
            string eingabe = $"{benutzername};{passwort}";
            clientSocket.Write("anmelden;"+eingabe);
            MessageBox.Show("yes");
        }
    }
}
