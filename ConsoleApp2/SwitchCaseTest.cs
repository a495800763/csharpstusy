using System;

namespace ConsoleApp2
{
    internal class SwitchCaseTest
    {
        public static void Function()
        {
            string[] friendsName = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };

            foreach (var friendName in friendsName)
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        Console.WriteLine("This friends name starts with a 'T':" +
                            $"{friendName} and is {t.Length - 1} letters long");
                        break;

                    case string e when e.Length == 0:
                        Console.WriteLine("There is a string in the array with no value");
                        break;

                    case null:
                        Console.WriteLine("There was a 'null' value in array");
                        break;

                    case var x:
                        Console.WriteLine("This is the var pattern of types:" +
                            $"{x.GetType().Name}");
                        break;

                    default:
                        break;
                }
            }

            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            foreach (var integer in myIntArray)
            {
                switch (integer)
                {
                    case 0:
                        Console.WriteLine($"Integer number '{total}' has a default value of 0");
                        total++;
                        break;

                    case int value:
                        sum += value;
                        counter++;
                        Console.WriteLine($"Integer number '{total}' has a default value of {value}");
                        total++;
                        break;

                    case null:
                        Console.WriteLine($"Integer number '{total}' is null");
                        total++;
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"{total} total integers,{counter} integers with a " + $" value other than 0 or null" +
                $"have a sum value of {sum}");
            Console.ReadLine();
        }
    }
}