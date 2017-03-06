using System;

namespace _02.ReverseArrayOfIntegers
{
    public class ReverseArrayOfIntegers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] reversed = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                reversed[n - 1 - i] = number;
            }


            for (int i = 0; i < reversed.Length; i++)
            {
                if (i< reversed.Length - 1)
                {
                    Console.Write("{0} ",reversed[i]);
                }
                else
                {
                    Console.WriteLine("{0}", reversed[i]);
                }
            }
        }
    }
}
