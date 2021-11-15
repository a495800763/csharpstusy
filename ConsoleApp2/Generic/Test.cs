using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generic
{
    class Test
    {
        public static void Main(string[] args)
        {
            //Vector v1 = GetVector("vector1");
            //Vector v2 = GetVector("vector2");
            //Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            //Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            //Console.ReadKey();

            Vectors route = new Vectors();
            route.Add(new Vector(2.0, 90.0));
            route.Add(new Vector(1.0, 180.0));
            route.Add(new Vector(0.5, 45.0));
            route.Add(new Vector(2.5, 315.0));
            Console.WriteLine(route.Sum());

            //比较条件的泛型委托
            Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
            route.Sort(sorter);

            Console.WriteLine(route.Sum());

            //逻辑条件的泛型委托
            Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);

            Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));

            Console.WriteLine(topRightQuadrantRoute.Sum());
            Console.ReadKey();


        }

        static Vector GetVector(string name)
        {
            Console.WriteLine($"Input {name} magnitude:");
            double? r = GetNullableDouble();
            Console.WriteLine($"Input {name} angle (in degrees):");
            double? theta = GetNullableDouble();
            return new Vector(r, theta);
        }

        static double? GetNullableDouble()
        {
            double? result;
            string userInput = Console.ReadLine();
            try
            {
                result = double.Parse(userInput);
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}
