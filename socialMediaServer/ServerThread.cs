using SocketAbi;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace socialMediaServer
{
    public class ServerThread
    {
        public SocketAbi.Socket client;
        public ServerThread(SocketAbi.Socket cs) 
        {
            this.client = cs;
        }

        public void HandleConnection()
        {
            while(true) 
            {
                string befehl = client.ReadLine();
                if(befehl.Contains("anmelden")) 
                {
                    Console.WriteLine("Test hat geklappt");
                }
            }
        }
    }
}
