using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SocketAbi;

namespace socialMediaServer
{
    public class Server
    {
        ServerSocket Serversocket;
        public Server(int port) 
        {
            this.Serversocket = new ServerSocket(port);
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            if (!Directory.Exists("img\\profile"))
                Directory.CreateDirectory("img\\profile");
            if (!Directory.Exists("img\\original"))
            {
                Directory.CreateDirectory("img\\original");
                Directory.CreateDirectory("img\\preview");
            }
            runServer();
        }

        public void runServer() 
        {
                while (true)
                {
                    Socket client = Serversocket.Accept();
                    ServerThread thread = new ServerThread(client);
                    Thread tc = new Thread(new ThreadStart(thread.HandleConnection));
                    tc.Start();
                }  
        } 
    }
}