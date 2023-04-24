using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDingTalk
{
    public interface IEasyDingTalk<TMessage, TResult>
    {
        string RequestUrl { get; }

        TResult SendMessage(TMessage message);
    }
}
