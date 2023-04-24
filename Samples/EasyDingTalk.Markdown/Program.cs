using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.Markdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keywords = "[senlin]";

            var markdownMsg = new MarkdownMessage
            {
                title = "杭州天气",
                text = $"#### 杭州天气 @150XXXXXXXX \n > 9度，西北风1级，空气良89，相对温度73%\n > ![screenshot](https://img.alicdn.com/tfs/TB1NwmBEL9TBuNjy1zbXXXpepXa-2400-1218.png)\n > ###### 10点20分发布 [天气](https://www.dingtalk.com) \n",
            };
            var message = new Message
            {
                Body = markdownMsg,
                at = new At
                {
                    isAtAll = true
                },
                msgtype = markdownMsg.msgtype,
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