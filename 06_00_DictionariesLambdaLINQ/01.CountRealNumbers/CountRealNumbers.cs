using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine().Trim()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> interm = new SortedDictionary<double, int>();

            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (!interm.ContainsKey(realNumbers[i]))
                {
                    interm[realNumbers[i]] = 1;
                }
                else
                {
                    interm[realNumbers[i]]++;

                }
            }

            foreach (var item in interm)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
