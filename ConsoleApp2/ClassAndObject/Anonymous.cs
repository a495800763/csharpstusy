using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{
    public class Anonymous
    {
        public static void Main(string[] args)
        {
            var animals = new[]
            {
                new { Name="Benjamin",Age=42,Weight=185},
                new { Name="Benjamin",Age=42,Weight=185},
                new { Name="Andrea",Age=46,Weight=109},
            };

            Console.WriteLine(animals[0].ToString());
            Console.WriteLine(animals[0].GetHashCode());
            Console.WriteLine(animals[1].GetHashCode());
            Console.WriteLine(animals[2].GetHashCode());
            Console.WriteLine(animals[0].Equals(animals[1]));//匿名类型上的equals比较的是全部属性值
            Console.WriteLine(animals[0].Equals(animals[2]));
            Console.WriteLine(animals[0] == animals[1]);
            Console.WriteLine(animals[0] == animals[2]);
            Console.ReadKey();
        }
    }
}
