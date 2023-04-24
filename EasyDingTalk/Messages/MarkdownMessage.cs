using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk.Messages
{
    public class MarkdownMessage: MessageBase
    {
        public MarkdownMessage()
        {
            msgtype = "markdown";
        }

        public string title { get; set; }
        public string text { get; set; }
    }
}
