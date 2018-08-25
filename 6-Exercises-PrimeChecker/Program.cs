using System;

namespace _6_Exercises_PrimeChecker
{
    class Program
    {
        static bool IsPrime(long n)
        {
            // важно е тук да е true иначе ако не влезем в долните ситуации ще ни дава грешка на половината тестове
            bool isPrime = true;
            if (n == 0|| n==1)
            {
                isPrime = false;
            }
            else if (n==2)
            {
                isPrime = true;
            }
            // ако не върти до корен квадратен от n ще ни дава лимит време
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        static void Main(string[] args)
        {
            //важно е да е long , а също и абсолютна стойност
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(IsPrime(n));
            
        }
    }
}
