using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    /// <summary>
    /// 参数数组
    /// </summary>
    public class ParamArray
    {
        public static int sumValues(params int[] vals)
        {
            int sum = 0;
            foreach (int i in vals)
            {
                sum += i;
            }

            return sum;
        }

        public static void Call()
        {
            int sum = sumValues(1, 5, 9, 4, 3);

            Console.WriteLine($"sum value is {sum}");

            Console.ReadKey();
        }
    }
}
