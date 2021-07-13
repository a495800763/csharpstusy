using static System.Console;
using static System.Convert;

namespace ConsoleApp2
{
    internal class BooleanTest
    {
        private static void Function(string[] args)
        {
            WriteLine("Enter an Integer");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (myInt >= 0) && (myInt <= 5);
            WriteLine($"Integer less than 10 ? {isLessThan10}");
            WriteLine($"Integer between 0 amnd 5 ? {isBetween0And5}");
            WriteLine($"Exactly one of above is true : " +
                $"{isLessThan10 ^ isBetween0And5}");
        }
    }
}