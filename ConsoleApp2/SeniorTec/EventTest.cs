using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2.SeniorTec
{
    class EventTest
    {
        static int counter = 0;
        static string displayString = "This string will appear one letter at a time";

        public static void Function (string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);//委托匹配对应的方法
            myTimer.Start();
            System.Threading.Thread.Sleep(200);
            Console.ReadKey();
        }

        static void WriteChar(object source,ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }
    }
}
