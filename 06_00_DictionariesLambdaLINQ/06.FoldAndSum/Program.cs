using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int lenghtFirst = arr.Length / 4;

            int[] firstPart = arr
                .Take(lenghtFirst)
                .Reverse()
                .ToArray();

            int[] lastPart = arr
                            .Reverse()
                            .Take(lenghtFirst)
                            .ToArray();

            int[] intermPart = arr
                .Skip(firstPart.Count())
                .Take(arr.Count() - (lenghtFirst*2))
                .ToArray();

            int[] firstAndLast = firstPart.Concat(lastPart).ToArray();
            List<string> result = new List<string>();

            for (int i = 0; i < intermPart.Length; i++)
            {
                long value = (long)firstAndLast[i] + intermPart[i];
                result.Add((value).ToString());
            }


            Console.WriteLine(string.Join(" ", result));

        }
    }
}
