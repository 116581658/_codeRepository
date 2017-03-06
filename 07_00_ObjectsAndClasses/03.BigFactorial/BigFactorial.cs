using System;
using System.Numerics;

namespace _03.BigFactorial
{
    public class BigFactorial
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            BigInteger number = 1;
            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }

            Console.WriteLine(number);

        }
    }
}
