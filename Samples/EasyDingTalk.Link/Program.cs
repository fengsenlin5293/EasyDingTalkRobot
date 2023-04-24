using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.Link
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keywords = "[senlin]";

            var linkmsg = new LinkMessage
            {
                title = "时代的火车向前开",
                text = $"这个即将发布的新版本，创始人xx称它为红树林。而在此之前，每当面临重大升级，产品经理们都会取一个应景的代号，这一次，为什么是红树林",
                picUrl = "https://cdn.pixabay.com/photo/2023/04/21/04/04/clouds-7941024_960_720.jpg",
                messageUrl = "https://www.dingtalk.com/s?__biz=MzA4NjMwMTA2Ng==&mid=2650316842&idx=1&sn=60da3ea2b29f1dcc43a7c8e4a7c97a16&scene=2&srcid=09189AnRJEdIiWVaKltFzNTw&from=timeline&isappinstalled=0&key=&ascene=2&uin=&devicetype=android-23&version=26031933&nettype=WIFI",
            };
            var message = new Message
            {
                Body = linkmsg,
                msgtype = linkmsg.msgtype,
            };

            //no Secret
            //EasyDingTalk easyDingTalk = new EasyDingTalk();
            //var rst = easyDingTalk.SendMessage(message);
            // Console.WriteLine(JsonConvert.SerializeObject(rst));

            //with Secret
            EasyDingTalkSecret easyDingTalkSecret = new EasyDingTalkSecret();
            var rstSecret = easyDingTalkSecret.SendMessage(message);
            Console.WriteLine(JsonConvert.SerializeObject(rstSecret));

            Console.ReadLine();
        }
    }
}