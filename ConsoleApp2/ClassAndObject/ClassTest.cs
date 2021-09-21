using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{

    public abstract class MyBase { }
    internal class MyClass : MyBase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyComplexClass : MyClass, IMyInterface {
        public override string ToString()
        {
            return "This is My New Class";
        }
    }
    class ClassTest
    {
        public static void Main(string[] args)
        {
            MyComplexClass myClass = new MyComplexClass();
            Console.WriteLine(myClass.ToString());
            Console.ReadKey();

        }
    }
}
