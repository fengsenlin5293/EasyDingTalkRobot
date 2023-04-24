using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace EasyDingTalk.Messages
{
    public class At
    {
        public bool isAtAll { get; set; }

        public List<string> atMobiles { get; set; } = new List<string>();

        public List<string> atUserIds { get; set; } = new List<string>();

    }


    [JsonConverter(typeof(MessageTypeConverter))]    
    public class Message
    {
        public string msgtype { get; set; }
        public MessageBase Body { get; set; }        
        public At at { get; set; }
    }

    public class MessageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            var t = value.GetType();
            var body = t.GetProperty("Body").GetValue(value) as MessageBase;
            var msgtype = t.GetProperty("msgtype").GetValue(value) as string;
            var at = t.GetProperty("at").GetValue(value);

            writer.WriteStartObject();

            writer.WritePropertyName("msgtype");
            writer.WriteValue(msgtype);

            writer.WritePropertyName(msgtype);
            serializer.Serialize(writer, body);

            if(at != null)
            {
                writer.WritePropertyName("at");
                serializer.Serialize(writer, at);
            }     

            writer.WriteEndObject();

        }
    }
}
