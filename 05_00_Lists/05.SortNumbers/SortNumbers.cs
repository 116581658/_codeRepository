using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();

            List<string> numAsText = new List<string>(numbers.Count());

            for (int i = 0; i < numbers.Count(); i++)
            {
                string concat = "" + numbers[i];
                numAsText.Add(concat);
            }

            Console.WriteLine(string.Join(" <= ", numAsText));

        }
    }
}
