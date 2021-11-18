using EventTest.EventTestSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventTest.EventTestSource
{

    //public delegate void MessageHandler(string messageText);

    class Connection
    {
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;  //事件关键字event 作用在一个委托上

        public string Name { get; set; }

        private Timer pollTimer;

        private static Random random = new Random();

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(Check4Message);
        }

        public void Connect()
        {
            pollTimer.Start();
        }

        public void DisConnect()
        {
            pollTimer.Stop();
        }

        private void Check4Message(object source, ElapsedEventArgs s)
        {
            Console.WriteLine("Checking for new message.");
            int nextVal = random.Next(4);
            if ((nextVal == 0) && (MessageArrived != null))
            {
                MessageArrived(this,new MessageArrivedEventArgs("Hello Mami!"));
            }
        }
    }
}
