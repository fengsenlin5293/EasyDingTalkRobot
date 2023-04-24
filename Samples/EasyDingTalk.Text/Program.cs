using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 钉钉!");

            var textmsg = new TextMessage
            {
                content = "Hello, 钉钉!"
            };
            var message = new Message
            {
                Body = textmsg,
                at = new At
                {
                    isAtAll = true
                },
                msgtype = textmsg.msgtype,
            };

            var sss = JsonConvert.SerializeObject(message);
            Console.WriteLine(sss);
        }
    }
}