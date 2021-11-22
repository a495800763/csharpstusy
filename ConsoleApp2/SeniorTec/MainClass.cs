using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.SeniorTec
{
    class MainClass
    {
        public static void Function(string[] args)
        {
            EventTest();
        }

        public static void EventTest()
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived += myDisplay.displayMessage;

            myConnection.Connect();
            Console.ReadKey();
        }
    }
}
