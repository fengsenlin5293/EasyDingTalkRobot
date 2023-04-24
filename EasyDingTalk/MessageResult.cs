using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EasyDingTalk
{
    public class MessageResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public bool IsSuccess
        {
            get
            {
                return errcode == 0;
            }
        }
    }
}
