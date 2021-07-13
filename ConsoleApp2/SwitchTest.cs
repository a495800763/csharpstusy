using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace ConsoleApp2
{
    class SwitchTest
    {
        public static void SwitchTestFunction()
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            WriteLine("what's your name ");
            name = ReadLine();
            switch(name.ToLower())
            {
                case myName:
                    WriteLine("you have a same name as me ");
                    break;
                case niceName:
                    WriteLine("you have a nicve name !");
                    break;
                case sillyName:
                    WriteLine("that a very silly name ");
                    break;
                default:
                    WriteLine($"hello {name}");
                    break;
            }

            ReadKey();
        }
    }
}
