using System;
using static System.Console;

namespace ConsoleApp2
{
    internal class Chapter03
    {
        private static void Function(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            WriteLine("Enter yiur name");
            userName = ReadLine();
            WriteLine($"welcome,{userName}");
            WriteLine("now give me a numBer");
            firstNumber = Convert.ToDouble(ReadLine());
            WriteLine("now give me another numBer");
            secondNumber = Convert.ToDouble(ReadLine());

            WriteLine($"thje sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
            WriteLine($"thje result of substrcing {secondNumber} from  {firstNumber} is {firstNumber - secondNumber}");
            WriteLine($"thje product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
            WriteLine($"thje result of dividing {firstNumber} by {secondNumber} is {firstNumber / secondNumber}");
            ReadKey();
        }
    }
}