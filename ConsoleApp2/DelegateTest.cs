using System;

namespace ConsoleApp2
{
    /// <summary>
    /// 委托测试
    /// </summary>
    internal class DelegateTest
    {
        private delegate double ProcessDelegate(double param1, double param2);

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static void Function()
        {
            ProcessDelegate process;
            Console.WriteLine("Enter 2 number swparated with comma :");
            string input = Console.ReadLine();
            string[] split = input.Split(',');
            double p1 = Convert.ToDouble(split[0]);
            double p2 = Convert.ToDouble(split[1]);
            Console.WriteLine("Enter M  4 Multiply and D  4 Devided :");
            string option = Console.ReadLine();
            if (option == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else if (option == "D")
            {
                process = new ProcessDelegate(Divide);
            }
            else
            {
                process = null;
                Console.WriteLine("请输入正确的操作符");
            }
            Console.WriteLine($"Result:{ process(p1, p2)}");
        }
    }
}