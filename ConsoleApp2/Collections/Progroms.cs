using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public class Progroms
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create an Array type collection of Animal " +
                               "objects and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow = new Cow("Lea");
            animalArray[0] = myCow;
            animalArray[1] = new Chicken("Noa");
            foreach(Animal myAnimal in animalArray)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to Array " +
                                  $"collection , Name = {myAnimal.Name}.");
            }
            Console.WriteLine($"Array collection contains {animalArray.Length} objects.");
            animalArray[0].Feed();//Animal基类中的方法不需要类型转换即可使用
            ((Chicken)animalArray[1]).LayEgg();//需要转换成子类对象后才能使用子类方法

            Console.WriteLine();
            Console.WriteLine("Create an ArrayList type collection of Animal" +
                              "objects and use it: ");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Donna");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Andrea"));
            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to ArrayList " +
                                  $"collection , Name = {myAnimal.Name}.");
            }
            Console.WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");
            ((Animal)animalArrayList[0]).Feed();//添加到未使用泛型的ArrayList 中的元素的类型被擦除了
            ((Chicken)animalArrayList[1]).LayEgg();//转换成子类才能使用子类的方法
            Console.WriteLine();
            Console.WriteLine("Addtional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);//arrayList可以addrange 一个数组
            ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine($"The animal called {myCow.Name} is at " +
                              $"index {animalArrayList.IndexOf(myCow)}");
            myCow.Name = "Liumengqi";
            Console.WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name}.");
            Console.ReadKey();
            
        }
    }
}
