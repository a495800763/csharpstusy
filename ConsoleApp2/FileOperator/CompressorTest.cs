using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using static System.Console;

namespace ConsoleApp2.FileOperator
{
    public class CompressorTest
    {
        /// <summary>
        /// 使用压缩方式写入文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void SaveCompressedFile(string fileName,string data)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Compress);
            StreamWriter sw = new StreamWriter(compressionStream);
            sw.Write(data);
            sw.Close();
        }

        /// <summary>
        /// 使用解压缩方式读取压缩文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string LoadCompressedFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Decompress);
            StreamReader sr = new StreamReader(compressionStream);
            string result = sr.ReadToEnd();
            sr.Close();
            return result;
        }

        public static void Main(string[] args)
        {
            try
            {
                string fileName = "compressedFile.txt";
                WriteLine("Enter a string to compress (will be repeated 100 times)");
                string sourceString = ReadLine();
                StringBuilder sourceStringMultiplier = new StringBuilder(sourceString.Length * 100);
                for(int i = 0; i < 100; i++)
                {
                    sourceStringMultiplier.Append(sourceString);
                }

                sourceString = sourceStringMultiplier.ToString();
                WriteLine($"Source data is {sourceString.Length} bytes long.");
                SaveCompressedFile(fileName, sourceString);
                WriteLine($"\nData saved to {fileName}");
                FileInfo compressedFileData = new FileInfo(fileName);
                Write($"Compresed file is {compressedFileData.Length}");
                WriteLine(" byte long.");
                string recoveredString = LoadCompressedFile(fileName);
                recoveredString = recoveredString.Substring(0, recoveredString.Length / 100);
                WriteLine($"\nRecovered data : {recoveredString}");
                ReadKey();

            }
            catch(IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
                ReadKey();
            }
        }
    }
}
