using System;

namespace ConsoleApp2.ClassAndObject
{
    public abstract class MyBase { }

    internal class MyClass : MyBase { }

    public interface IMyBaseInterface { }

    internal interface IMyBaseInterface2 { }

    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }

    internal sealed class MyComplexClass : MyClass, IMyInterface
    {
        public override string ToString()
        {
            return "This is My New Class";
        }
    }

    internal class ClassTest
    {
        public static void Function(string[] args)
        {
            MyComplexClass myClass = new MyComplexClass();
            Console.WriteLine(myClass.ToString());
            Console.ReadKey();
        }
    }
}