using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 类型转换
/// </summary>
namespace ConsoleApp2
{
    class TypeTransfer
    {
        public static void Function1()
        {
            //字符类型可以和ushort类型隐式转换
            ushort destinationVar;
            char sourceVar = 'a';
            destinationVar = sourceVar;
            Console.WriteLine($"source var is {sourceVar}");
            Console.WriteLine($"destination var is {destinationVar}");
            Console.ReadKey();
        }

        public static void Function2()
        {

        }
    }
}
