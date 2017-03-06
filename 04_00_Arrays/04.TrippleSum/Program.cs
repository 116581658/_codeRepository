using System;
using System.Numerics;
namespace _04.TrippleSum
{
    public class TrippleSum
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Trim().Split(' ');
            BigInteger[] numbers = new BigInteger[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = BigInteger.Parse(array[i]);
            }

            bool hasMatches = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length ; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        BigInteger sum = numbers[i] + numbers[j];
                        BigInteger result = numbers[k];
                        if (sum == result)
                        {
                            Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], numbers[k]);
                            hasMatches = true;
                            break;  // This break was ESSENTIAL otherwise, test with 6 0 6, to see 2 rows per found equal result
                        }
                    }
                }
            }

             if (!hasMatches)
            {
                Console.WriteLine("No");
            }

        }
    }
}
