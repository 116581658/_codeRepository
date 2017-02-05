using System;

namespace _01.BlankReceipt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            PrintReciept();
        }

        public static void PrintReciept()
        {
            PrintReceiptHeader();
            PrintReceiptCharged();
            PrintReceiptReceived();
            WriteSoftUniLogo();
        }

        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            WriteSymbolsInLine("-", 30);
        }

        public static void PrintReceiptCharged()
        {
            Console.Write("Charged to");
            WriteSymbolsInLine("_", 20);

        }
        public static void PrintReceiptReceived()
        {
            Console.Write("Received by");
            WriteSymbolsInLine("_", 19);

        }
        public static void PrintReceiptFooter()
        {
            Console.WriteLine("CASH RECEIPT");
        }

        public static void WriteSoftUniLogo()
        {
            char registered = '\u00A9';
            
            WriteSymbolsInLine("-", 30);
            Console.WriteLine($"{registered} SoftUni");
        }

        public static void WriteSymbolsInLine(string symbol, int num)
        {
            for (int i=1; i<= num; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

    }
}
