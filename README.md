# EasyDingTalkRobot

[![GitHub Stars](https://img.shields.io/github/stars/fengsenlin5293/EasyDingTalkRobot?style=social)](https://github.com/fengsenlin5293/EasyDingTalkRobot)
![visitor](https://visitor-badge.glitch.me/badge?page_id=fengsenlin5293.EasyDingTalkRobot&right_color=green&left_text=Visitors)

如果喜欢它，并且能够帮到您，希望可以给一个Star⭐，非常感谢 🙏。

## 🤖创建钉钉自定义机器人

<img src="https://help-static-aliyun-doc.aliyuncs.com/assets/img/zh-CN/5750865761/p556317.gif">
<details>
    <summary><b>创建自定义机器人详细步骤</b></summary>
    <br>

1.  选择需要添加机器人的群聊，然后依次单击<b>群设置</b> >  <b>智能群助手</b> 。 <img src="https://help-static-aliyun-doc.aliyuncs.com/assets/img/zh-CN/5750865761/p556317.gif">
2.  在机器人管理页面选择<b>自定义</b>机器人，输入机器人名字并选择要发送消息的群，同时可以为机器人设置机器人头像。 <img src="https://help-static-aliyun-doc.aliyuncs.com/assets/img/zh-CN/5750865761/p556333.png"> <img src="https://help-static-aliyun-doc.aliyuncs.com/assets/img/zh-CN/5750865761/p556338.png">

</details>

## 📤消息类型预览

* TextMessage

![TextMessage](https://user-images.githubusercontent.com/16472159/234022082-0dfbed0c-b4dc-4957-993f-71648da5ed70.png)

* LinkMessage

![LinkMessage](https://user-images.githubusercontent.com/16472159/234024027-7dd42032-de05-4222-841e-b58de8506c5b.png)

*   MarkdownMessage

![MarkdownMessage](https://user-images.githubusercontent.com/16472159/234024935-0902b6d3-9725-49ee-85fc-c142a5e3b22e.png)

*   ActionCardMessage

 <table style="margin-left: auto; margin-right: auto;">
    <tr>
        <td>
           <img src="https://user-images.githubusercontent.com/16472159/234191567-e96d8772-fc11-4ba2-8e47-e61e3f32b493.png" alt="ActionCard-整体跳转" width=488><center style="font-size:14px;text-decoration:underline">ActionCard-整体跳转</center> 
        </td>
        <td>
         <img src="https://user-images.githubusercontent.com/16472159/234026471-7d41b043-8ed3-4a58-8f36-aab742a12c52.png" alt="ActionCard-独立跳转"><center style="font-size:14px;text-decoration:underline">ActionCard-独立跳转</center> 
        </td>
    </tr>
</table>



*   FeedCardMessage

![FeedCardMessage](https://user-images.githubusercontent.com/16472159/234027379-1ebd406a-cb31-4211-b39e-9edc7b2bb88c.png)

## 💡如何使用

* **具体类型消息内容：**
``` C#
var textmsg = new TextMessage
{
    content = $"Hello, 钉钉!"
};
```
上面消息为`TextMessage`类型，还有其他消息类型：`LinkMessage`、`MarkdownMessage`、`ActionCardMessage`、`FeedCardMessage`，其他消息类型可参考`Samples`文件夹里的例子。

* **完整消息内容：**
``` C#
var message = new Message
{
    Body = textmsg,
    at = new At
    {
        isAtAll = true
    },
    msgtype = textmsg.msgtype,
};
```

* **发送消息**
  
1. 自定义关键字   
   ``` C#
    EasyDingTalk easyDingTalk = new EasyDingTalk();
    var rst = easyDingTalk.SendMessage(message);
   ```
   如果`安全设置`勾选并设置了自定义关键字，则需要在消息内容里面包含你所设置的关键字
   
2. 加签
   ``` C#
    EasyDingTalkSecret easyDingTalkSecret = new EasyDingTalkSecret();
    var rstSecret = easyDingTalkSecret.SendMessage(message);
   ```
   如果`安全设置`勾选了`加签`，则需要在`settings.json`文件内配置`secret`的值，用于签名计算。

* **配置`settings.json`**
  ``` json
  {
    "host": "https://oapi.dingtalk.com/robot/send",
    "access_token": "xxxxxx",
    "secret": "xxxxxx"
  }
  ``` 
  **`access_token`**: 为添加机器人后自动生成的`Webhook`后面的<i>access_token</i>=**xxxxxx**值。

  **`secret`**: 为`安全设置`勾选了`加签`后自动生成的密钥。

## ⭐Star History

<p align="center">
  <a href="https://star-history.com/#fengsenlin5293/EasyDingTalkRobot&Date">
    <img src="https://api.star-history.com/svg?repos=fengsenlin5293/EasyDingTalkRobot&type=Date" alt="Star History Chart">
  </a>
</p>
