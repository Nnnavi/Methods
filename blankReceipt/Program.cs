using System;

namespace blankReceipt
{
    class Program
    {
        
        static void Main(string[] args)
      {
        void PrintReceiptHeader()
        {
                  Console.WriteLine("CASH RECEIPT");
                  Console.WriteLine("------------------------------");
        }
        void PrintReceiptBody()
        {
            Console.WriteLine("Charged to___________________");
            Console.WriteLine("Received by__________________");
            Console.WriteLine("------------------------------------");
        }
        void PrintReceiptFooter()
        {
            Console.WriteLine("\u00A9 SoftUni");
        }
        void PrintReceipt()
        {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
        
        }
            
            
        PrintReceipt();
            {
             }
       }
    }
}
