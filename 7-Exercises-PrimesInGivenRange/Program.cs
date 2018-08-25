using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_Exercises_PrimeChecker
{
    class Program
    {
        static void FindPrimesInRange(int startNum, int endNum)
        {
           
           
            var primes = "";

            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 0 || i == 1)
                {
                    i = 2;
                }
                bool isPrime = true;
                for (int j = 2; j <=Math.Sqrt(i); j++)
                {
                                      
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes = primes + i + ", ";
                }
            }
            primes = primes.Substring(0, primes.Length - 2);
            Console.WriteLine(primes);

            
        }
        static void Main(string[] args)
        {
           
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            FindPrimesInRange(startNum,endNum);

        }
    }
}
