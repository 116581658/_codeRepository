using System;

namespace _08MostFrequentNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Trim().Split(' ');

            int[] numbers = new int[text.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(text[i]);
            }

            int numberICount = 0;
            int numberI = 0;
            int numberJCount = 0;
            int numberJ = 0;
            int bestCount = 0;

            numberI = numbers[0];
            numberICount = CountOccurence(numbers, numberI);
            for (int j = 0; j < numbers.Length; j++)
            {
                numberJ = numbers[j];
                numberJCount = CountOccurence(numbers, numberJ);
                if (numberI != numberJ)
                {
                    if (numberICount < numberJCount)
                    {
                        bestCount = numberJCount;
                        numberICount = bestCount;
                        numberI = numberJ;
                    }
                    else
                    {
                        bestCount = numberICount;
                        numberICount = bestCount;
                    }
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine(numberI);
        }

        public static int CountOccurence(int[] array, int num)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
