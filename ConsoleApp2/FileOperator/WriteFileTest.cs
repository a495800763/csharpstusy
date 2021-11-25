using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2.FileOperator
{
    public class WriteFileTest
    {
        public static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;
            try
            {
                //在当前路径下新建一个txt文件
                FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
                charData = "My Pink half of the drainpipe . ".ToCharArray();
                byteData = new byte[charData.Length];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                //Move file pointer to beginning of file
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteData, 0, byteData.Length);
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
