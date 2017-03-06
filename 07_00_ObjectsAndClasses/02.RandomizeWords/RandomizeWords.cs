using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();

            Random rand = new Random();

            int n = text.Length;
            List<string> randomizedText = new List<string>();
            while (n > 0)
            {
               int randomNumber = (int)(rand.NextDouble() * 10 * text.Length) % text.Length;

                if (!randomizedText.Contains(text[randomNumber]))
                {
                    randomizedText.Add(text[randomNumber]);
                    n--;
                }
            }

            Console.WriteLine(string.Join("\n",randomizedText));


        }
    }
}
