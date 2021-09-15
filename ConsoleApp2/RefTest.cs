using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RefTest
    {
        public static void test()
        {
            int myNumber = 5;
            ref int myNumberRef = ref myNumber;
            myNumber =  6;
            Console.WriteLine($"myNumber is  changed to 6");
            Console.WriteLine($"myNumber is {myNumber}");
            Console.WriteLine($"myNumberRef is {myNumberRef}");
        }
    }
}
