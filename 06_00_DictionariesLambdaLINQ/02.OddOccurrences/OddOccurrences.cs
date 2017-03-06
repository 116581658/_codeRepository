using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().ToLower().Trim().Split().ToArray();

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!result.ContainsKey(text[i]))
                {
                    result[text[i]] = 1;
                }
                else
                {
                    result[text[i]]++;
                }

            }

            List<string> items = new List<string>();
            foreach (var thing in result)
            {
                if (thing.Value % 2 != 0)
                {
                    items.Add(thing.Key);
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}

