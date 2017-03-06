using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    public class CountNumbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (nums.Count > 0)
            {
                nums.Sort();
                int previous = nums[0];
                int counter = 1;
                for (int i = 1; i < nums.Count(); i++)
                {
                    int minValue = nums[i];
                    int maxValue = nums[nums.Count() - 1];
                    int next = nums[i];
                    if (minValue >= 0 && maxValue <= 1000)
                    {
                        if (previous == next)
                        {
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("{0} -> {1}", previous, counter);
                            previous = next;
                            counter = 1;
                        }
                    }
                    else
                    {
                        nums = new List<int>();
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", previous, counter);

            }
        }
    }
}
