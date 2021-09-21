using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// 异常过滤器测试类
    /// </summary>
    class ExceptionFilterTest
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
        
        static void MainNew(string[] args)
        {
            foreach(var type in eTypes)
            {
                try
                {
                    Console.WriteLine("Main() try block reached. ");
                    Console.WriteLine($"ThrowException(\"{type}\") called.");
                    ThrowException(type);
                    Console.WriteLine("Main() try block continues.");
                }
                catch (System.IndexOutOfRangeException e ) when (type == "filter")
                {
                    //BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Main() FILTERED System.IndexOutOfRangeException" + $"catch block reached. Message:\n\"{e.Message}\"");
                }
                catch(System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Main() System.IndexOutOfRangeException" + $"catch block reached. Message:\n\"{e.Message}\"");
                }
                catch
                {
                    Console.WriteLine("Main{} general catch block reached.");
                }
                finally
                {
                    Console.WriteLine("Main{} finally block reached.");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ThrowException(string exceptionType)
        {
            Console.WriteLine($"ThrowException (\"{exceptionType}\" reached.");
            switch (exceptionType)
            {
                case "none":
                    Console.WriteLine("Not throwing an exception .");
                    break;
                case "simple":
                    Console.WriteLine("Throwing System.Exception.");
                    break;
                case "index":
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";
                    break;
                case "nested index":
                    try
                    {
                        Console.WriteLine("ThrowException (\"nexsted index\")" + "try block reached.");
                        Console.WriteLine("ThrowException(\"index\") called . ");
                        ThrowException("index");
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException (\"nexsted index\")" + "catch block reached.");
                        throw;
                    }
                    finally
                    {
                        Console.WriteLine("ThrowException (\"nexsted index\")" + "finally block reached.");
                    }
                    break;
                case "filter":
                    try
                    {
                        Console.WriteLine("ThrowException (\"filter\")" + "try block reached.");
                        Console.WriteLine("ThrowException(\"index\") called . ");
                        ThrowException("index");
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException (\"filter\")" + "catch block reached.");
                        throw;
                    }
                    break;
            }
        }
    }
}
