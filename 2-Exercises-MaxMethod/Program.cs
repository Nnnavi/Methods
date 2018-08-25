using System;

namespace _2_Exercises_MaxMethod
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int result = 0;
            if (a>b)
            {
                result = a;
            }
            else
            {
               result = b;
            }
            return result;
        }
        static int GetMax(int a,int b,int c)
        {
            int result = 0;
            if (GetMax(a,b)<c)
            {
                result= c;
            }
            else if (GetMax(b,c)<a)
            {
                result= a;
            }
            else if (GetMax(a,c)<b)
            {
                result= b;
            }
            return result; 
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

           
            Console.WriteLine(GetMax(a,b,c));
        }

        
    }
}
