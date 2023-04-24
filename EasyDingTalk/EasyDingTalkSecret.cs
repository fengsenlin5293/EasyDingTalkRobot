using EasyDingTalk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk
{
    public class EasyDingTalkSecret : IEasyDingTalk<MessageBase, MessageResult>
    {
        private string _secret;

        public string RequestUrl { get ; }

        public EasyDingTalkSecret(string host,string access_token,string secret)
        {
            _secret = secret;
            RequestUrl = $"{host}?access_token={access_token}";
        }

        public MessageResult SendMessage(MessageBase message)
        {
            var timestamp = GetTimeStamp();
            var sign = GetSign(_secret, timestamp);
            string url = $"{RequestUrl}&timestamp={timestamp}&sign={sign}";
            throw new NotImplementedException();
        }

        private string GetTimeStamp()
        {
            return ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
        }

        private string GetSign(string secret, string timestamp)
        {
            string stringToSign = timestamp + "\n" + secret;
            System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(secret));
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            return Convert.ToBase64String(hashBytes);
        }
    }
}
