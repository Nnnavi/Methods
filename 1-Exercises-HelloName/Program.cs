using System;

namespace _1_Exercises_HelloName
{
    class Program
    {
        static void HelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }
    }
}
