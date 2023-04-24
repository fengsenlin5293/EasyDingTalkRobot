using EasyDingTalk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk
{
    public class EasyDingTalk : IEasyDingTalk<MessageBase, MessageResult>
    {
        public string RequestUrl { get; }
        public EasyDingTalk(string host, string access_token)
        {
            RequestUrl = $"{host}?access_token={access_token}";
        }
        public MessageResult SendMessage(MessageBase message)
        {
            throw new NotImplementedException();
        }
    }
}
