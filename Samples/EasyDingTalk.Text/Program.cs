﻿using EasyDingTalk.Messages;
using Newtonsoft.Json;

namespace EasyDingTalk.Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keywords = "[senlin]";

            var textmsg = new TextMessage
            {
                content = $"{keywords}: Hello, 钉钉!"
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

            //no Secret
            //EasyDingTalk easyDingTalk = new EasyDingTalk();
            //var rst = easyDingTalk.SendMessage(message);
            //Console.WriteLine(JsonConvert.SerializeObject(rst));


            //with Secret
            EasyDingTalkSecret easyDingTalkSecret = new EasyDingTalkSecret();
            var rstSecret = easyDingTalkSecret.SendMessage(message);
            Console.WriteLine(JsonConvert.SerializeObject(rstSecret));

            Console.ReadLine();
        }
    }
}