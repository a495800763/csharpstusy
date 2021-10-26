using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{
    /// <summary>
    /// 结构类型和类的区别
    /// </summary>
    class StructAndClassTest
    {
        static void Main(string[] args)
        {
            //MyClassNew objA = new MyClassNew();
            //MyClassNew objB = objA;
            //objA.val = 10;
            //objB.val = 20;

            //MyStructNew structA = new MyStructNew();
            //MyStructNew structB = structA;
            //structA.val = 30;
            //structB.val = 40;

            //Console.WriteLine($"objA val is {objA.val}");
            //Console.WriteLine($"objB val is {objB.val}");
            //Console.WriteLine($"structA val is {structA.val}");
            //Console.WriteLine($"structB val is {structB.val}");

            MyVirtualDerivedClass myObj = new MyVirtualDerivedClass();
            MyVirtualBaseClass myBaseObj;
            myBaseObj = myObj;
            myBaseObj.Dosomething();

            Console.ReadKey();

        }
    }

    class MyClassNew
    {
        public int val;
    }

    struct MyStructNew
    {
        public int val;
    }
}
