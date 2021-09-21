using System;

namespace ConsoleApp2
{
    internal enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    public class EnumTest
    {
        public static void Function()
        {
            orientation myDerection = orientation.north;
            Console.WriteLine($@"myDerection is {myDerection}, it's value is {(int)myDerection}");
            Console.ReadKey();
        }
    }
}