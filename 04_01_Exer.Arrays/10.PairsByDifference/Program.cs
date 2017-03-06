using System;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersSeq = Console.ReadLine().Trim().Split(' ');
            int diff = int.Parse(Console.ReadLine());
            int[] inNumbers = new int[numbersSeq.Length];
            for (int i = 0; i < numbersSeq.Length; i++)
            {
                inNumbers[i] = int.Parse(numbersSeq[i]);
            }


            int counter = 0;
            for (int i = 0; i < numbersSeq.Length - 1; i++)
            {
                for (int j = i + 1; j < numbersSeq.Length; j++)
                {
                    if (Math.Abs(inNumbers[i] - inNumbers[j]) == diff)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
