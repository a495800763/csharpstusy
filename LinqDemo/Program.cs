using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinqDemo
{
    class Program
    {
        static void Function(string[] args)
        {
            string[] names = { "Alonso","Zheng","Smith","Jones","Smythe","Small","Ruiz","Hsieh","Jorgenson","Ilyich","Singh",
            "Samba","Fatimah"};

            //查询语法
            //var queryResult =
            //    from n in names
            //    where n.StartsWith("S")
            //    select n;

            //方法语法
            var queryResult = names.Where(q => q.StartsWith("S")).OrderByDescending(q=>q);


            WriteLine("Names beginning with S:");
            foreach(var item in queryResult)
            {
                WriteLine(item.ToString());
            }

            Write("Program finished.press Enter/Return to continue.");
            ReadLine();
        }
    }
}
