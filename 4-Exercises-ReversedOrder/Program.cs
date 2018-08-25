using System;

namespace _4_Exercises_ReversedOrder
{
    class Program
    {
        static string ReversedOrder(string revNum)
        {
            
            for (int i = revNum.Length - 1; i >= 0; i--)
                Console.Write(revNum[i]);
            return revNum; 
        }
        static void Main(string[] args)
        {
            string revNum = Console.ReadLine();
           ReversedOrder(revNum);
        }
    }
}
