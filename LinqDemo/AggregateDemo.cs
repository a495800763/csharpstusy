using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinqDemo
{
    /// <summary>
    /// Linq中的聚合运算符demo
    /// </summary>
    public class AggregateDemo
    {
        public static void Fucntion(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(12345678);

            WriteLine("Numeric Aggredates");
            var queryResults =
                from n in numbers
                where n > 1000
                select n;

            //var queryResult = numbers.Where(q => q < 1000);

            WriteLine("Count of numbers >1000");
            WriteLine(queryResults.Count());
            WriteLine("Max of numbers >1000");
            WriteLine(queryResults.Max());
            WriteLine("Min of numbers >1000");
            WriteLine(queryResults.Min());
            WriteLine("Average of numbers >1000");
            WriteLine(queryResults.Average());
            WriteLine("Sum of numbers >1000");
            //求和的值可能超出int 的范围，改成long类型
            WriteLine(queryResults.Sum(n=>(long)n));

            Write("Program finished.press Enter/Return to continue.");
            ReadLine();
        }

        private static int[] GenerateLotsOfNumbers(int count)
        {
            Random generator = new Random(0);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = generator.Next();
            }
            return result;
        }
    }
}
