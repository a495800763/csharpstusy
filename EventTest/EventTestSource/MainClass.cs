using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.EventTestSource
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EventTest();
        }

        public static void EventTest()
        {
            Connection myConnection1 = new Connection();
            myConnection1.Name = "First Connection";
            Connection myConnection2 = new Connection();
            myConnection2.Name = "Second Connection";

            Display myDisplay = new Display();//事件响应（监听器）

            myConnection1.MessageArrived += myDisplay.displayMessage;//监听器监听first
            myConnection2.MessageArrived += myDisplay.displayMessage;//监听器监听second
            myConnection1.Connect();//first 开始
            myConnection2.Connect();//second 开始

            System.Threading.Thread.Sleep(200);
            Console.ReadKey();

        }
    }
}
