using System;

namespace _04.SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] theSieve = new int[n + 1];
            if (n > 1)
            {
                for (int i = 0; i < theSieve.Length; i++)
                {
                    theSieve[i] = i;
                }

                theSieve[0] = -1;
                theSieve[1] = -1;
                for (int i = 0; i < theSieve.Length; i++)
                {
                    if (theSieve[i] != -1)
                    {
                        int counter = 2;
                        for (int j = i * i; j < theSieve.Length; j = i * counter)
                        {
                            theSieve[j] = -1;
                            counter++;
                        }
                    }
                    else
                    {
                        continue;
                    }

                }

                int lastPrime = FindMaxValid(theSieve);

                for (int i = 0; i < theSieve.Length; i++)
                {
                    if (theSieve[i] != -1)
                    {
                        if (i < lastPrime)
                        {
                            Console.Write("{0} ", theSieve[i]);
                        }
                        else if (i == lastPrime)
                        {
                            Console.WriteLine("{0}", theSieve[i]);
                        }
                    }
                }

            }
        }

        public static int FindMaxValid(int[] array)
        {
            int maxIndex = array.Length - 1;
            for (int j = maxIndex; j > 0; j--)
            {
                if (array[j] != -1)
                {
                    maxIndex = j;
                    break;
                }
            }

            return maxIndex;
        }

    }
}
