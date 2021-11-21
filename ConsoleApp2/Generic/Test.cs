using ConsoleApp2.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generic
{
    class Test
    {
        public static void Function (string[] args)
        {
            //Vector v1 = GetVector("vector1");
            //Vector v2 = GetVector("vector2");
            //Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            //Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            //Console.ReadKey();

            //Vectors route = new Vectors();
            //route.Add(new Vector(2.0, 90.0));
            //route.Add(new Vector(1.0, 180.0));
            //route.Add(new Vector(0.5, 45.0));
            //route.Add(new Vector(2.5, 315.0));
            //Console.WriteLine(route.Sum());

            ////比较条件的泛型委托
            //Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
            //route.Sort(sorter);

            //Console.WriteLine(route.Sum());

            ////逻辑条件的泛型委托
            //Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);

            //Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));

            //Console.WriteLine(topRightQuadrantRoute.Sum());
            //Console.ReadKey();


            //Dictionary<string, int> things = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            //List<Cow> cows = new List<Cow>();
            //cows.Add(new Cow("Rual"));
            //cows.Add(new SupperCow("Donna"));
            //cows.Add(new Cow("Mary"));
            //cows.Add(new Cow("Ben"));
            //cows.Sort(new AnimalNameLengthComparer());
            //Console.WriteLine(cows.ToString());
            //Console.ReadKey();
        }

        static void Test1()
        {
        //    Farm<Animal> farm = new Farm<Animal>();
        //    farm.Animals.Add(new Cow("A"));
        //    farm.Animals.Add(new Chicken("B"));
        //    farm.Animals.Add(new Chicken("C"));
        //    farm.Animals.Add(new SupperCow("D"));

        //    farm.MakeNoise();

        //    Farm<Cow> cows = farm.getCows();

        //    foreach (Cow cow in cows)
        //    {
        //        if (cow is SupperCow)
        //        {
        //            ((SupperCow)cow).Fly();
        //        }
        //    }

        //    Console.ReadKey();
        //}

        //static Vector GetVector(string name)
        //{
        //    Console.WriteLine($"Input {name} magnitude:");
        //    double? r = GetNullableDouble();
        //    Console.WriteLine($"Input {name} angle (in degrees):");
        //    double? theta = GetNullableDouble();
        //    return new Vector(r, theta);
        //}

        //static double? GetNullableDouble()
        //{
        //    double? result;
        //    string userInput = Console.ReadLine();
        //    try
        //    {
        //        result = double.Parse(userInput);
        //    }
        //    catch
        //    {
        //        result = null;
        //    }
        //    return result;
        }
    }
}
