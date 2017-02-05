using System;

namespace _02.SignfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var theNumber = int.Parse(Console.ReadLine());
            PrintSign(theNumber);
        }


        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }

    }
}
;