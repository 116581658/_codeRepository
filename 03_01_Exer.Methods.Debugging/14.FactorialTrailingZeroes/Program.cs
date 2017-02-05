using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger theNumber = Factorial(number);
            Console.WriteLine("{0}", CalculateTrailingZeros(theNumber));
        }


        public static BigInteger Factorial(int value)
        {
            BigInteger factorial = 1;
            if (value == 1)
            {
                return factorial;
            }
            else
            {
                for (int i = 2; i <= value; i++)
                {
                    factorial *= i;
                }
            }

            return factorial;

        }


        public static int CalculateTrailingZeros(BigInteger value)
        {

            int counter = 0;
            while (value % 10 == 0)
            {
                counter++;
                value /= 10;

            }

            return counter;
        }

    }
}
