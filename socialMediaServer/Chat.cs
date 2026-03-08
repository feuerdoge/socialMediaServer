using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialMediaServer
{
    public class Chat
    {
        public int ChatId { get; set; }
        public Chat(int chatId)
        {
            this.ChatId = chatId;
        }
    }
}
