using static System.Console;
using static System.Convert;

namespace ConsoleApp2
{
    internal class DoWhileTest
    {
        public static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("what's your current balance");
            balance = ToDouble(ReadLine());
            WriteLine("what's your current annual interest rate (in % ) ?");
            interestRate = 1 + ToDouble(ReadLine()) / 100;
            WriteLine("what balance woule you like to have");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;
            do
            {
                balance += interestRate;
                ++totalYears;
            } while (balance < targetBalance);

            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")}" + $"you'll have a balance of {balance}");
            ReadKey();
        }
    }
}