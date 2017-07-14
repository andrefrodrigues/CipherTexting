using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// This model represents the message model
    /// </summary>
    class Message
    {
        public DateTime SentTime { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public string MessageContent { get; set; }
    }
}
