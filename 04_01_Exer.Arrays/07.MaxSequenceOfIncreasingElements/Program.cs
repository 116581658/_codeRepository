using System;

namespace _07.MaxSequenceOfIncreasingConsecutiveElements
{
    public class MaxSequenceOfIncreasingConsecutiveElements
    {
        public static void Main(string[] args)
        {
            
            string[] text = Console.ReadLine().Trim().Split(' ');
            int[] num = new int[text.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(text[i]);
            }

            int beforeI = 0;
            int counter = 1;
            int minIndex = 0;
            int maxIndex = 1;
            int maxLength = 1;
            int firstEl = 0;
            int secondEl = 0;
            for (int i = 0; i <= num.Length; i++)
            {
                if (i == 0)
                {
                    beforeI = 0;
                    firstEl = num[i];
                    secondEl = num[beforeI];
                }
                else if (i < num.Length)
                {
                    beforeI = i - 1;
                    firstEl = num[i];
                    secondEl = num[beforeI];
                }
                else if (i == num.Length)
                {
                    beforeI = i - 1;
                    secondEl = num[beforeI];
                    firstEl = secondEl -2;
                }


               if (firstEl - secondEl != 1)
                    {
                    if (counter > maxLength)
                    {
                        maxIndex = i;
                        minIndex = maxIndex - counter;
                        maxLength = counter;
                        counter = 1;

                    }
                    else
                    {
                        counter = 1;
                    }


                }
                else
                {
                    counter++;
                }

            }

            PrintSubString(num, minIndex, maxIndex);

        }

        public static void PrintSubString(int[] array, int indexStart, int indexEnd)
        {
            for (int i = indexStart; i < indexEnd; i++)
            {
                if (i < indexEnd - 1)
                {
                    Console.Write("{0} ", array[i]);
                }
                else
                {
                    Console.WriteLine("{0}", array[i]);
                }
            }
        }

    }
}
