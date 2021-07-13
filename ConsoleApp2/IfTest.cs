using static System.Console;
using static System.Convert;

namespace ConsoleApp2
{
    internal class IfTest
    {
        public static void Function()
        {
            string comparisionp;
            WriteLine("Enter a number");
            //读取一个键盘输入转换为double类型
            double var1 = ToDouble(ReadLine());
            WriteLine("Enter another number");
            double var2 = ToDouble(ReadLine());
            if (var1 < var2)
            {
                comparisionp = "less than";
            }
            else
            {
                if (var1 == var2)
                {
                    comparisionp = "equal to";
                }
                else
                {
                    comparisionp = "greater than";
                }
            }

            WriteLine($"the first number is {comparisionp} the second number");
            ReadLine();
        }
    }
}