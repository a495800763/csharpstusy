using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    class Primes
    {
        private long min;
        private long max;

        public Primes() : this(2, 100) { }

        public Primes(long minimum,long maximum)
        {
            if (minimum < 2)
            {
                min = 2;
            }
            else
            {
                min = minimum;
            }
            max = maximum;
        }

        //得到迭代器
        public IEnumerator GetEnumerator()
        {
            for(long possiblePrime = min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for(long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrime % possibleFactor;
                    if (remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //是素数的话就把这个数放到迭代器中，记住这种写法/*
                   yield return possiblePrime;
                }
            }
        }

        public static void Main(string[] args)
        {
            Primes test = new Primes(2, 10000);
            foreach (long i in test)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadKey();
        }
    }
}
