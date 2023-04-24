using EasyDingTalk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EasyDingTalk.Utilities;

namespace EasyDingTalk
{
    public class EasyDingTalk : IEasyDingTalk<Message, MessageResult>
    {
        #region constructor

        public EasyDingTalk(string host, string access_token)
        {
            RequestUrl = $"{host}?access_token={access_token}";
        }

        public EasyDingTalk(string settingsJsonPath)
        {
            string url = SettingsUtil.CreateUrlFromJsonFile(settingsJsonPath);
            RequestUrl = url;
        }

        public EasyDingTalk()
        {
            var settingsPath = SettingsUtil.ResolvePath("settings.json");
            string url = SettingsUtil.CreateUrlFromJsonFile(settingsPath);
            RequestUrl = url;
        }
        #endregion

        #region interface implementation


        public string RequestUrl { get; }

        public MessageResult SendMessage(Message message)
        {
            return RequestUrl.PostJsonAsync(message).ReceiveJson<MessageResult>().Result;
        }

        public Task<MessageResult> SendMessageAsync(Message message)
        {
            return RequestUrl.PostJsonAsync(message).ReceiveJson<MessageResult>();
        }
        #endregion


    }
}
