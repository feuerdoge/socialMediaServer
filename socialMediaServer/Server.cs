using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocketAbi;

namespace socialMediaServer
{
    public class Server
    {
        ServerSocket socket;

        public Server(int port) 
        {
            this.socket = new ServerSocket(port);
        }

        public void runServer() 
        {
            while(true) 
            {
                socket.Accept();
                ServerThread thread = new ServerThread();
            }
            
        } 
    }
}