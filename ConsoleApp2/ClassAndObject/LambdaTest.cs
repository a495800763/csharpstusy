using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{

    /// <summary>
    /// 两个整数操作的委托
    /// </summary>
    /// <param name="paramA"></param>
    /// <param name="paramB"></param>
    /// <returns></returns>
    delegate int TwoIntegerOperationDelegate(int paramA, int paramB);

    public class LambdaTest
    {
        static void PerformOperations(TwoIntegerOperationDelegate del)
        {
            for (int paramAVal = 1; paramAVal <= 5; paramAVal++)
            {
                for (int paramBVal = 1; paramBVal <= 5; paramBVal++)
                {
                    int delegateCellResult = del(paramAVal, paramBVal);
                    Console.Write($"f({paramAVal},{paramBVal})={delegateCellResult}");
                    if (paramBVal != 5)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("f(a,b) = a+b:");
            PerformOperations((p, q) => p + q);
            Console.WriteLine("f(a,b) = a*b:");
            PerformOperations((p, q) => p * q);
            Console.WriteLine("f(a,b) = (a-b) % b:");
            PerformOperations((p, q) => (p - q) % q);
            Console.ReadKey();
        }
    }
}
