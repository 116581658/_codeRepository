using System;

namespace _03.FoldAndSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Trim().Split(' ');
            int sectionLen = text.Length / 4;
            string[] textLeft = new string[sectionLen];
            string[] textRight = new string[sectionLen];
            for (int i = 0; i < sectionLen; i++)
            {
                textLeft[i] = text[i];
                textRight[i] = text[text.Length - 1 - i];
            }

            textLeft = ReverseArrays(textLeft);
            string[] concatenatedLeftRight = ConcatArrays(textLeft, textRight);

            int[] numbers = new int[sectionLen * 2];
            int[] concatenatedNumbers = new int[sectionLen * 2];
            int[] sum = new int[sectionLen * 2];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(text[sectionLen]);
                concatenatedNumbers[i] = int.Parse(concatenatedLeftRight[i]);
                sum[i] = numbers[i] + concatenatedNumbers[i];
                sectionLen++;
            }

            string newText = string.Join(" ", sum);
            Console.WriteLine(newText);

        }


        public static int[] ReverseArrays(int[] array)
        {
            int[] reversed = new int[array.Length];

            for (int i = 0; i <= reversed.Length / 2; i++)
            {
                reversed[i] = array[reversed.Length - 1 - i];
                reversed[reversed.Length - 1 - i] = array[i];
            }

            return reversed;
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

        public static string[] ConcatArrays(string[] array1, string[] array2)
        {
            string text1 = string.Join(" ", array1);
            string text2 = string.Join(" ", array2);
            string[] concatenated = (text1 + " " + text2).Trim().Split(' ');
            return concatenated;
        }
    }
}
