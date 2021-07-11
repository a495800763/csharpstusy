using System;

namespace ConsoleApp2
{
    internal class Chapter03
    {
        private static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            String userName;
            Console.WriteLine("Enter yiur name");
            userName = Console.ReadLine();
            Console.WriteLine($"welcome,{userName}");
            Console.WriteLine("now give me a numBer");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("now give me another numBer");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"thje sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
            Console.WriteLine($"thje result of substrcing {secondNumber} from  {firstNumber} is {firstNumber - secondNumber}");
            Console.WriteLine($"thje product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
            Console.WriteLine($"thje result of dividing {firstNumber} by {secondNumber} is {firstNumber / secondNumber}");
            Console.ReadKey();
        }
    }
}