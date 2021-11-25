using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2.FileOperator
{
    public class StreamWriterTest
    {
        public static void Function(string[] args)
        {
            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                bool truth = true;
                //write data to file
                sw.WriteLine("Hello to you ");
                sw.Write($"It is now {DateTime.Now.ToLongDateString()}");
                sw.Write("and things are looking good.");
                sw.Write("more than that,");
                sw.Write($"it's {truth} that c# is fun.");
                sw.Close();
            }catch(IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }
            
        }
    }
}
