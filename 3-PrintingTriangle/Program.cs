using System;

namespace _3_PrintingTriangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
           
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int start = 1;
            for (int i = 0; i < end; i++)
            {
                PrintLine(1,i);
            }
            PrintLine(1,end);
            for (int i = end-1; i >=0; i--)
            {
                PrintLine(1,i);
            }
        }
    }
}
