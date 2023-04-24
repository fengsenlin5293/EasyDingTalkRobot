using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    public class TextMessage : MessageBase
    {
        public TextMessage()
        {
            msgtype = "text";
        }
        public string content { get; set; }
    }
}
