using EasyDingTalk.Messages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using EasyDingTalk.Utilities;

namespace EasyDingTalk
{
    public class EasyDingTalkSecret : IEasyDingTalk<Message, MessageResult>
    {
        private string _secret;

        #region constructor
        public EasyDingTalkSecret(string host, string access_token, string secret)
        {
            _secret = secret;
            RequestUrl = $"{host}?access_token={access_token}";
        }

        public EasyDingTalkSecret()
        {
            var settingsPath = SettingsUtil.ResolvePath("settings.json");
            var settings = SettingsUtil.GetSettingFromJsonFile(settingsPath);            
            RequestUrl = $"{settings.host}?access_token={settings.access_token}";

            _secret = settings.secret;
        }
        #endregion

        #region interface implementation

        public string RequestUrl { get; }

        public MessageResult SendMessage(Message message)
        {         
            string url = CreateUrl();
            return url.PostJsonAsync(message).ReceiveJson<MessageResult>().Result;
        }

        public Task<MessageResult> SendMessageAsync(Message message)
        {        
            string url = CreateUrl();
            return RequestUrl.PostJsonAsync(message).ReceiveJson<MessageResult>();
        }
        #endregion


        #region private methods

        private string CreateUrl()
        {
            var timestamp = GetTimeStamp();
            var sign = GetSign(_secret, timestamp);
            string url = $"{RequestUrl}&timestamp={timestamp}&sign={sign}";
            return url;
        }

        DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
        private string GetTimeStamp()
        {
            return (Convert.ToInt64((DateTime.Now - startTime).TotalMilliseconds)).ToString();
        }

        private string GetSign(string secret, string timestamp)
        {
            string stringToSign = timestamp + "\n" + secret;
            System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(secret));
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            return Convert.ToBase64String(hashBytes);
        }
        #endregion

    }
}
