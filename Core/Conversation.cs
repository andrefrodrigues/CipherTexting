using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// This model represents the conversation between your user and another one
    /// </summary>
    class Conversation
    {
        public User LocalUser { get; set; }
        public User OtherUser { get; set; }
        public string SimmetricKey { get; set; }
        //all messages stored here are not ciphered, available for the user to verify
        public List<Message> Messages { get; set; }
    }
}
