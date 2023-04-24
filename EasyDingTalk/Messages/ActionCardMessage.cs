using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    public class Btn
    {
        public string title { get; set; }
        public string actionURL { get; set; }
    }
    public class ActionCardMessage : MessageBase
    {
        public ActionCardMessage()
        {
            msgtype = "actionCard";
        }
 
        public string title { get; set; }
        public string text { get; set; }
        public string singleTitle { get; set; }
        public string singleURL { get; set; }
        public string btnOrientation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Btn> btns { get; set; }
    }
}
