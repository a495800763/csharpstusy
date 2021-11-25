using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{
    /// <summary>
    /// 求累加和的lambda表达式
    /// </summary>
    class AggregateTest
    {
        public static void Function(string[] args)
        {
            string[] people = { "Donna", "Mary", "Andrea" };
            Console.WriteLine(people.Aggregate((p, q) => { return p + "" + q; }));
            Console.WriteLine(people.Aggregate<string, int>(0, (p, q) => { return p + q.Length; }));
            Console.WriteLine(people.Aggregate<string, string, string>("Some people all length", (p, q) => { return p + "" + q; }, p => p));
            Console.WriteLine(people.Aggregate<string, string, int>("Some people all length", (p, q) => { return p + "" + q; }, p => p.Length));
            Console.ReadKey();
        }
    }
}
