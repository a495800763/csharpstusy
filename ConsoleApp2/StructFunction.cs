using System;

namespace ConsoleApp2
{
    /// <summary>
    /// 结构体中的函数 测试
    /// </summary>
    internal class StructFunction
    {
        public static void Function(string[] args)
        {
            CustomerName person;
            person.firstName = "Liu";
            person.lastName = "Mengqi";
            Console.WriteLine(person.Name());
        }
    }

    internal struct CustomerName
    {
        public string firstName, lastName;

        //结构体中定义函数
        public string Name() => firstName + ";" + lastName;
    }
}