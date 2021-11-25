using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.FileOperator
{
    class ReadFileTest
    {
        public static void Function(string[] args)
        {
            byte[] byteData = new byte[200];
            char[] charData = new char[200];

            try
            {
                FileStream aFile = new FileStream(@"..\..\FileOperator\ReadFileTest.cs", FileMode.Open);
                //从文件的起始位置往后推174位开始
                aFile.Seek(174, SeekOrigin.Begin);
                aFile.Read(byteData, 0, 200);
            }catch(IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }
            //基于UTF-8将字节流转换为字符，以供控制台显示
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);
            Console.WriteLine(charData);
            Console.ReadKey();
        }
    }
}
