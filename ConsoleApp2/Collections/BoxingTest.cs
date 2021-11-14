using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{ 
    class BoxingTest
    {
        public static void Function (string[] args)
        {
            MyStruct valType1 = new MyStruct();
            valType1.val = 5;
            object refType = valType1;
            valType1.val = 6;

            MyStruct valType2 = (MyStruct)refType;
            Console.WriteLine(valType2.val);
            Console.ReadKey();
        }
    }

    class MyStruct
    {
        public int val;
    }
}
