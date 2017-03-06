using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Trim()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var result = nums
                 .OrderByDescending(x => x)
                 .Take(3)
                 .ToArray();


            Console.WriteLine(string.Join(" ", result));

        }
    }
}
