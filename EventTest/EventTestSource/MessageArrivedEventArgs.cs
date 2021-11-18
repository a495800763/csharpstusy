using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.EventTestSource
{
    /// <summary>
    /// 自定义事件参数
    /// </summary>
    public class MessageArrivedEventArgs:EventArgs
    {
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
        }

        public MessageArrivedEventArgs()
        {
            message = "No message sent.";
        }

        public MessageArrivedEventArgs(string newMessage)
        {
            message = newMessage;
        }
    }
}
