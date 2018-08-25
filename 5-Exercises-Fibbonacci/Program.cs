using System;

namespace _5_Exercises_Fibbonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            int fibonacci1 = 1;
            int fibonacci2 = 1;
            int fibonaccin = 0;
            for (int i = 1; i < n; i++)
            {
                fibonaccin = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonaccin;
            }
            return fibonaccin;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n==0)
            {
                Console.WriteLine("0");
            }
            else if (n==1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(Fib(n));
            }
            
        }
    }
}
