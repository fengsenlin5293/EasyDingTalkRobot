using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    public class FeedCard
    {
        public string title { get; set; }
        public string messageURL { get; set; }
        public string picURL { get; set; }
    }
    public class FeedCardMessage : MessageBase
    {
        public FeedCardMessage()
        {
            msgtype = "feedCard";
        }
        public List<FeedCard> links { get; set; } = new List<FeedCard>();
    }
}
