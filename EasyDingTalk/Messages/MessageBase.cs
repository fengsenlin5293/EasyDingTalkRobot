using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    //[JsonConverter(typeof(MessageTypeConverter))]
    public class MessageBase
    {
        [Newtonsoft.Json.JsonIgnore]
        public string msgtype { get; protected set; }
    }
}
