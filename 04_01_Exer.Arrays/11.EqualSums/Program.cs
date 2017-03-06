using System;

namespace _11.EqualSums
{
    public class EqualSums
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Trim().Split(' ');
            int[] numbers = new int[text.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(text[i]);
            }


            int index = 1;
            int sumBeforeIndex = 0;
            int sumAfterIndex = 0;
            bool notEqual = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 && numbers.Length == 1)
                {
                    sumBeforeIndex = 0;
                    sumAfterIndex = 0;
                }
                else if ((i != 0) && (i - numbers.Length == -1))
                {
                    sumBeforeIndex = CalcArraySum(numbers, 0, i);
                    sumAfterIndex = 0;

                }
                else if ((i == 0) && (i - numbers.Length > -1))
                {
                    sumBeforeIndex = 0;
                    sumAfterIndex = CalcArraySum(numbers, i + 1, numbers.Length);
                }
                else
                {
                    sumBeforeIndex = CalcArraySum(numbers, 0, i);
                    sumAfterIndex = CalcArraySum(numbers, i + 1, numbers.Length);
                }


                if ((sumBeforeIndex == sumAfterIndex))
                {
                    index = i;
                    notEqual = false;
                    break;
                }
                else
                {
                    notEqual = true;
                }
            }


            if (notEqual)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        public static int CalcArraySum(int[] array, int indexBegin, int indexEnd)
        {
            int sum = 0;
            if (indexBegin >= 0 && indexEnd <= array.Length)
            {
                for (int i = indexBegin; i < indexEnd; i++)
                {
                    sum += array[i];
                }
            }
            else
            {
                sum = -1;
            }

            return sum;
        }

    }
}
