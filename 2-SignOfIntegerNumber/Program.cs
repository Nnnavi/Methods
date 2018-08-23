using System;

namespace _2_SignOfIntegerNumber
{
    class Program
    {
        static void PrintSign(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else if (n == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
