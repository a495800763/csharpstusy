using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// 结构体中的函数 测试
    /// </summary>
    class StructFunction
    {
        public static void Function (string[] args)
        {
            CustomerName person;
            person.firstName = "Liu";
            person.lastName = "Mengqi";
            Console.WriteLine(person.Name());
        }
    }

    struct CustomerName
    {
        public string firstName, lastName;
        //结构体中定义函数
        public string Name() => firstName + ";" + lastName;
    }
}
