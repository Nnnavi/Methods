using System;

namespace _9_MultiplyEvensByOdds
{
    class Program
    {
        private static int GetSumOfOddDigits(int n)
        {
            //odd digits
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n%10;
                if (lastDigit%2!=0)
                {
                    sum+=lastDigit;
                }
                n/=10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            //even digits
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n%10;
                if (lastDigit%2==0)
                {
                    sum+=lastDigit;
                }
                n/=10;
            }
            return sum;
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
    }
}
