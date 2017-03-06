using System;

namespace _09.ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Trim().Split(' ');

            int[] numbers = new int[array.Length];

            if (array.Length == 1)
            {
                numbers = new int[array.Length];

                numbers[0] = int.Parse(array[0]);

            }
            else if (array.Length % 2 == 0)
            {
                numbers = new int[2];
                int k = 0;
                for (int i = (array.Length / 2) - 1; i < (array.Length / 2) + 1; i++)
                {
                    numbers[k] = int.Parse(array[i]);
                    k++;
                }
            }
            else if (array.Length % 2 == 1)
            {
                numbers = new int[3];
                int k = 0;
                for (int i = (array.Length / 2) - 1; i <= (array.Length / 2) + 1; i++)
                {
                    numbers[k] = int.Parse(array[i]);
                    k++;
                }
            }

            string newText = string.Join(", ", numbers);
            Console.WriteLine("{ " + newText + " }");

        }
    }
}
