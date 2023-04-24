using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.FeedCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keywords = "[senlin]";

            var feedCardMsg = new FeedCardMessage
            {
                links =
                {
                    new Messages.FeedCard
                    {
                        title = "Steve Jobs",
                        messageURL = "https://www.dingtalk.com/",
                        picURL = "https://cdn.pixabay.com/photo/2018/04/17/08/52/steve-jobs-3326938_960_720.jpg"
                    },
                    new Messages.FeedCard
                    {
                        title = "Stay Hungry",
                        messageURL = "https://www.dingtalk.com/",
                        picURL = "https://cdn.pixabay.com/photo/2015/05/08/15/26/apple-758333_960_720.jpg"
                    },
                    new Messages.FeedCard
                    {
                        title = "Mac Pro",
                        messageURL = "https://www.dingtalk.com/",
                        picURL = "https://cdn.pixabay.com/photo/2020/04/08/20/16/mac-pro-and-pro-display-xdr-5018763_960_720.jpg"
                    },
                }
            };
            var message = new Message
            {
                Body = feedCardMsg,
                msgtype = feedCardMsg.msgtype,
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