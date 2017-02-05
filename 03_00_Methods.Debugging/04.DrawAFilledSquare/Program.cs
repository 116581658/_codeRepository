using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number > 1)
                {
                    DrawFilledSquire(number);
                }
                else
                {
                    Console.WriteLine("wrong value");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong number");
            }

        }


        static void DrawFilledSquire(int size)
        {
            DrawDashedLine(size);
            // PrintMiddleRow(size);
            DrawVs(size);
            DrawDashedLine(size);

        }

        static void DrawDashedLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void DrawVs(int n)
        {

            for (int i = 1; i <= n-2; i++)
            {
                for (int j = 1; j <= n * 2; j++)
                {
                    if (j == 1 || j == n * 2)
                    {
                        Console.Write("-");
                    }
                    else if (j % 2 == 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }

                Console.WriteLine();
            }
        }


    }
}
