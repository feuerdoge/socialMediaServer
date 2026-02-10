using SocketAbi;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        public ServerThread(SocketAbi.Socket cs) 
        {
            this.client = cs;
            spf = new SocialMediaPlatform();
        }

        public void HandleConnection()
        {
            Console.WriteLine("Client hat sich verbunden!");
            while(true) 
            {
                string befehl = client.ReadLine();
                Console.WriteLine("Test");
                if(befehl.Contains("anmelden")) 
                {
                    Console.WriteLine("Test hat geklappt");
                }
            }
        }
    }
}
