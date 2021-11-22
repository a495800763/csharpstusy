using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ClassAndObject
{
    public class WordProcessor
    {

        public static void Function(string[] args)
        {
            string sentence = "his gaze against the sweeping bars has grown so weary";
            List<string> words;
            words = WordProcessor.GetWords(sentence);
            Console.WriteLine("Original sentence:");
            foreach(string word in words)
            {
                Console.Write(word);
                Console.Write(' ');
            }
            Console.Write('\n');
            words = WordProcessor.GetWords(sentence, reverseWords: true, capitalizeWords: true);
            Console.WriteLine("Capitalized sentence with reversed words:");
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(' ');
            }
            Console.ReadKey();
        }

        public static List<string> GetWords(
            string sentence,
            bool capitalizeWords = false,
            bool reverseOrder = false,
            bool reverseWords = false
            )
        {
            List<string> words = new List<string>(sentence.Split(' '));
            if (capitalizeWords)
            {
                words = CapitalizeWords(words);
            }
            if (reverseOrder)
            {
                words = ReverseOrder(words);
            }
            if (reverseWords)
            {
                words = ReverseWords(words);
            }
            return words;
        }

        private static List<string> CapitalizeWords(List<string> words)
        {
            List<string> capitalizedWords = new List<string>();
            foreach(string word in words)
            {
                if (word.Length == 0)
                {
                    continue;
                }
                if (word.Length == 1)
                {
                    capitalizedWords.Add(word[0].ToString().ToUpper());
                }
                else
                {
                    capitalizedWords.Add(word[0].ToString().ToUpper()+word.Substring(1));
                }
            }
            return capitalizedWords;
        }

        private static List<string>  ReverseOrder (List<string> words)
        {
            List<string> reverseWords = new List<string>();
            for(int wordIndex = words.Count - 1; wordIndex >= 0; wordIndex--)
            {
                reverseWords.Add(words[wordIndex]);
            }
            return reverseWords;
        }

        private static List<string>  ReverseWords(List<string> words)
        {
            List<string> reverseWords = new List<string>();
            foreach(string word in words)
            {
                reverseWords.Add(ReverseWord(word));
            }
            return reverseWords;
        }

        private static string ReverseWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            for(int characterIndex = word.Length - 1; characterIndex >= 0; characterIndex--)
            {
                sb.Append(word[characterIndex]);
            }
            return sb.ToString();
        }
    }
}
