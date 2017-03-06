using System;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Trim().Split(' ');
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[text1.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(text1[i]);
            }

            int[] sum = new int[numbers.Length];
            int[] rotatedArray = new int[0];

            while (k>0)
            {
                rotatedArray = RotateArray(numbers, "r");
                numbers = rotatedArray;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum[i] += numbers[i] ;
                }
                k--;

            }

            string newText = string.Join(" ", sum);
            Console.WriteLine(newText);

        }

        public static int[] RotateArray(int[] arr, string direction)
        {
            int[] array = (int[])arr.Clone();

            if (direction == "r")
            {
                int temp = array[array.Length - 1];

                for (int i = array.Length -1; i>= 0; i--)
                {
                    if (i>=1)
                    {
                        array[i] = array[i - 1];
                    }
                    else
                    {
                        array[i] = temp;
                    }
                }

            }
            else
            {
                int temp = array[0];

                for (int i = 0; i< array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        array[i] = array[i + 1];
                    }
                    else
                    {
                        array[i] = temp;
                    }
                }
            }
            return array;


        }

    }
}
