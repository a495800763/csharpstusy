using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ArrayTest
    {
        public static  void Function()
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            for(int i =0;i<friendNames.Length;i++)
            {
                Console.WriteLine(friendNames[i] + "\n");
            }
            Console.ReadKey();
        }
    }
}
