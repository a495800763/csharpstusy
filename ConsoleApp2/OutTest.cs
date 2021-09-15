using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// out 关键字测试
    /// </summary>
    class OutTest
    {
        public static void call()
        {
            int[] myArray = { 1, 2, 6, 2, 62, 35, 16, 23, 695, 3642, 153, };
            Console.WriteLine($"The max value in this array is {MaxValue(myArray, out int maxIndex)}");
            Console.WriteLine($"The max value in the Index of {maxIndex}");
            Console.ReadKey();
        }

        public static int MaxValue(int[] intArray,out int maxIndex)
        {
            int maxValue = intArray[0];
            maxIndex = 0;
            for(int  i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] >= maxValue)
                {
                    maxValue = intArray[i];
                    maxIndex = i;
                }
            }

            return maxValue;
        }
    }
}
