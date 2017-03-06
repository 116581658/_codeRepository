using System;

namespace _08.CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Trim().Split(' ');

            int[] numbers = new int[array.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            int[] total = SumTheNumbers(numbers, numbers.Length);
            Console.WriteLine("{0}", total[0]);


        }

        public static int[] SumTheNumbers(int[] theArray, int theLength)
        {
            int[] theCopy = (int[])theArray.Clone();
            int[] theSum = new int[theCopy.Length - 1];
            while (theLength - 1 > 0)
            {
                for (int i = 0; i < theLength - 1; i++)
                {
                    theSum[i] = theCopy[i] + theCopy[i + 1];
                }

                theCopy = (int[])theSum.Clone();
                theLength--;
                theSum = new int[theLength - 1];
            }

            return theCopy;
        }
    }
}
