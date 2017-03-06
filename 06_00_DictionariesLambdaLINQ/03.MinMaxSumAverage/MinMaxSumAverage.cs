using System;
using System.Collections.Generic;
using System.Linq;

// Write a program to read n integers and print their sum, min, max, first, last and average values.

namespace _03.MinMaxSumAverage
{
    public class MinMaxSumAverage
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();
            while (n>0)
            {
                int number = int.Parse(Console.ReadLine());
                nums.Add(number);
                n--;
            }

            int[] integers = nums.ToArray();

            string[] operations = new string[] { "Sum", "Min", "Max", "Average" };
            Dictionary<string, double> result = new Dictionary<string, double>();
            
            foreach (var value in operations)
            {
                switch (value)
                {
                    case "Sum":
                        result[value] = integers.Sum();
                        break;
                    case "Min":
                        result[value] = integers.Min();
                        break;
                    case "Max":
                        result[value] = integers.Max();
                        break;
                    case "First":
                        result[value] = integers.First();
                        break;
                    case "Last":
                        result[value] = integers.Last();
                        break;
                    case "Average":
                        result[value] = integers.Average();
                        break;
                }

            }


            foreach (var item in result)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

        }
    }
}
