using System;

namespace _01.LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Trim().Split(' ');
            string[] text2 = Console.ReadLine().Trim().Split(' ');
            int counterLeft = CompareMaxCommonText(text1, text2);

            string[] reversedText1 = ReverseArrays(text1);
            string[] reversedText2 = ReverseArrays(text2);
            int counterRight = CompareMaxCommonText(reversedText1, reversedText2);

            if ((counterLeft >= counterRight))
            {
                Console.WriteLine("{0}", counterLeft);
            }
            else
            {
                Console.WriteLine("{0}", counterRight);
            }
        }


        public static string[] ReverseArrays(string[] array)
        {
            string[] reversed = new string[array.Length];

            for (int i = 0; i <= reversed.Length / 2; i++)
            {
                reversed[i] = array[reversed.Length - 1 - i];
                reversed[reversed.Length - 1 - i] = array[i];
            }

            return reversed;
        }

        public static int CompareMaxCommonText(string[] array1, string[] array2)
        {
            int counter = 0;
            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i].Equals(array2[i]))
                {
                    counter++;
                    continue;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

    }
}
