using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Function(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\" myInteger \" is/8* ";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();
        }
    }
}