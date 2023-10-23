using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLib
{
    /// <summary>
    /// Class for defining message you want to send and to whom you want to send it.
    /// recipient can change from phone number to email adress depending on method used in
    /// </summary>
    public class Message
    {
        public string recipient;
        public string content;

        public Message() { }
        public Message(string recipient, string content ) 
        {
            this.recipient = recipient;
            this.content = content;
        }
    }
}
