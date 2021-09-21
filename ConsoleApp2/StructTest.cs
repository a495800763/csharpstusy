using System;

namespace ConsoleApp2
{
    internal enum Orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    /// <summary>
    /// 路由 结构体
    /// </summary>
    internal struct route
    {
        //方向
        public Orientation direction;

        //距离
        public double distance;
    }

    internal class StructTest
    {
        public static void Function()
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) Sourth\n3) East\n4) West");
            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));

            Console.WriteLine("Input a Distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine($"MyRoute specifies as direction of {myRoute.direction}" +
                $"  and a distance of {myRoute.distance}");
            Console.ReadKey();
        }
    }
}