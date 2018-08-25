using System;

namespace _3_Exercises_EnglishNameOfTheLastDigit
{
    class Program
    {
        static string NameOfTheLastDigit(int number)
        {
            string NameOfTheLastDigit="";
            int LastDigit = number % 10;
            if (LastDigit==0)
            {
                NameOfTheLastDigit = "zero";
            }
            else if (LastDigit==1)
            {
                NameOfTheLastDigit = "one";
            }
            else if (LastDigit==2)
            {
                NameOfTheLastDigit = "two";
            }
            else if (LastDigit == 3)
            {
                NameOfTheLastDigit = "three";
            }
            else if (LastDigit == 4)
            {
                NameOfTheLastDigit = "four";
            }
            else if (LastDigit == 5)
            {
                NameOfTheLastDigit = "five";
            }
            else if (LastDigit == 6)
            {
                NameOfTheLastDigit = "six";
            }
            else if (LastDigit == 7)
            {
                NameOfTheLastDigit = "seven";
            }
            else if (LastDigit == 8)
            {
                NameOfTheLastDigit = "eight";
            }
            else if (LastDigit == 9)
            {
                NameOfTheLastDigit = "nine";
            }
            return NameOfTheLastDigit;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NameOfTheLastDigit(number));
        }
    }
}
