using System;

namespace _06.PrimeChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            bool theCheck = IsPrime(number);
            Console.WriteLine(theCheck);
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
