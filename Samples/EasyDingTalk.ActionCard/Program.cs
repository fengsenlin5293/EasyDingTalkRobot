using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.ActionCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keywords = "[senlin]";

            var actionCardMsg = new ActionCardMessage
            {
                title = "乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
                text = $"![screenshot](https://cdn.pixabay.com/photo/2018/04/17/08/52/steve-jobs-3326938_960_720.jpg) \r\n ### 乔布斯 20 年前想打造的苹果咖啡厅 \r\n Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
                btnOrientation = "0",
                singleTitle = "阅读全文",
                singleURL = "https://www.dingtalk.com/"
            };
            var message = new Message
            {
                Body = actionCardMsg,
                msgtype = actionCardMsg.msgtype,
            };

            var singleJumpActionCardMsg = new ActionCardMessage
            {
                title = "乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
                text = $"![screenshot](https://cdn.pixabay.com/photo/2018/04/17/08/52/steve-jobs-3326938_960_720.jpg) \r\n ### 乔布斯 20 年前想打造的苹果咖啡厅 \r\n Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
                btnOrientation = "0",
                btns = new List<Btn>
                {
                    new Btn
                    {
                        title = "内容不错",
                        actionURL = "https://www.dingtalk.com/"
                    },
                    new Btn
                    {
                        title = "不感兴趣",
                        actionURL = "https://www.dingtalk.com/"
                    }
                }
            };

            var singleJumpMessage = new Message
            {
                Body = singleJumpActionCardMsg,
                msgtype = singleJumpActionCardMsg.msgtype,
            };

            //no Secret
            //EasyDingTalk easyDingTalk = new EasyDingTalk();
            //var rst = easyDingTalk.SendMessage(message);
            // Console.WriteLine(JsonConvert.SerializeObject(rst));

            //with Secret
            EasyDingTalkSecret easyDingTalkSecret = new EasyDingTalkSecret();
            //var rstSecret = easyDingTalkSecret.SendMessage(message);
            var rstSecret = easyDingTalkSecret.SendMessage(singleJumpMessage);
            Console.WriteLine(JsonConvert.SerializeObject(rstSecret));

            Console.ReadLine();
        }
    }
}