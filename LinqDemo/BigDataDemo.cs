using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinqDemo
{
    public class BigDataDemo
    {
        public static void Function(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(12045678);
            //var queryResult =
            //    from n in numbers
            //    where n < 1000
            //    select n;

            var queryResult = numbers.Where(q => q < 1000);

            WriteLine("Numbers less than 1000:");
            foreach(var item in queryResult)
            {
                WriteLine(item);
            }

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
