using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            //list.RemoveAll(x => x < 0)
            List<int> secondList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] >= 0)
                {
                    secondList.Add(list[i]);
                }
            }

            // bool isEmpty = !secondList.Any();
            if (secondList.Count() == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < secondList.Count(); i++)
                {
                    if (i < secondList.Count - 1)
                    {
                        Console.Write("{0} ", secondList[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}", secondList[i]);
                    }
                }
            }

        }
    }
}

