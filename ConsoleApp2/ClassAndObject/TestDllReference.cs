using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTestLib;

namespace ConsoleApp2.ClassAndObject
{
    class TestDllReference
    {
        public static void Main(string[] args)
        {
            MyExternalClassNew myObj = new MyExternalClassNew();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
