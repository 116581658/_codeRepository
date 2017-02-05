
using System;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangles(n);

        }

        static void PrintColumns(int maxColNr)
        {
            for (int j = 1; j <= maxColNr; j++)
            {
                Console.Write(j);
                if (j < maxColNr)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        static void PrintTriangles(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintColumns(i);
            }


            for (int i = 1; i <= num; i++)
            {
                PrintColumns(num - i);
            }
        }
    }
}
