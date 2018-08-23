using System;

namespace blankReceipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
                  Console.WriteLine("CASH RECEIPT");
                  Console.WriteLine("------------------------------");
        }
        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceiptFooter()
        {
            Console.WriteLine("\u00A9 SoftUni");
        }
        private static void PrintReceipt()
        {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
        
        }
        static void Main(string[] args)
        {
        PrintReceipt();
        }
    }
}
