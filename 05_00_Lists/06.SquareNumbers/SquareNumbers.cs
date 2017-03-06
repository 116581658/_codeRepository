using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> sqList = new List<int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    sqList.Add(nums[i]);
                }
            }

            sqList.Sort((a, b) => b.CompareTo(a));
            List<string> theResult = new List<string>(sqList.Count());

            for (int i = 0; i < sqList.Count(); i++)
            {
                string someTe = "" + sqList[i];
                theResult.Add(someTe);
            }

            Console.WriteLine(string.Join(" ", theResult));

        }
    }
}
