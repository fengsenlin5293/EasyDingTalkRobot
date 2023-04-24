using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    public class LinkMessage : MessageBase
    {
        public LinkMessage()
        {
            msgtype = "link";
        }
        public string messageUrl { get; set; }
        public string picUrl { get; set; }
        public string title { get; set; }
        public string text { get; set; }
    }
}
