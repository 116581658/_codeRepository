using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {

            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            string result = GetPrimes(FindPrimesInRange(firstNumber, secondNumber));
            Console.WriteLine(result);

        }


        public static string GetPrimes(List<long> listWithPrimes)
        {
            string values = string.Empty;

            foreach (var item in listWithPrimes)
            {
                values = string.Join(", ", listWithPrimes);
            }

            return values;
        }


        public static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> primeNumbers = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i) == true)
                {
                    primeNumbers.Add(i);
                }

            }

            return primeNumbers;
        }


        public static bool IsPrime(long number)
        {
            bool isPrimeChecker = false;

            if (number == 2 || number == 3)
            {
                isPrimeChecker = true;
            }
            else
            {
                double sqrtN = Math.Sqrt(number);
                for (long i = 2; i <= sqrtN; i++)
                {
                    if ((number % i != 0) && (i != 1 && i != number))
                    {
                        isPrimeChecker = true;
                    }
                    else
                    {
                        isPrimeChecker = false;
                        break;
                    }
                }
            }
            return isPrimeChecker;
        }

    }
}
