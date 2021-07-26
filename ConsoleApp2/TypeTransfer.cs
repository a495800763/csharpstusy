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
            //显示转换测试
            byte destinationVar;
            short sourceVar = 7;
            destinationVar = (byte)sourceVar;
            Console.WriteLine($"sourceVar is :{sourceVar}");
            Console.WriteLine($"destinationVar is :{destinationVar}");
            Console.ReadKey();
        }

        public static void Function3()
        {
            //大值转小值时，丢失位数
            byte destinationVar;
            short sourceVar = 281;
            destinationVar = (byte)sourceVar;
            Console.WriteLine($"sourceVar is :{sourceVar}");
            Console.WriteLine($"destinationVar is :{destinationVar}");
            Console.ReadKey();
        }

        public static void Function4()
        {
            short shortResult, shortVar = 4;
            int integerVar = 67;
            long longResult;
            float floatVal = 10.5f;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVar;
            Console.WriteLine($"Implicit,-> double:{floatVal} * {shortVar} ->{doubleResult}");
            shortResult = (short)floatVal;
            Console.WriteLine($"Explicit,-> short:{floatVal} -> {shortResult} ");
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit,-> string:\"{boolVal}\" + \"{doubleVal}\" -> \"{stringResult}\" ");
            longResult = integerVar + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed,-> long: {integerVar}+{stringVal} -->{longResult} ");
            Console.ReadKey();

        }
    }
}
