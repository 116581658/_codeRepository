using System;

namespace _07.SumArrays
{
    public class SumArrays
    {
        public static void Main(string[] args)
        {

            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            string[] array1 = text1.Trim().Split(' ');
            string[] array2 = text2.Trim().Split(' ');
            int[] numbers1 = new int[Math.Max(array1.Length, array2.Length)];
            int[] numbers2 = new int[Math.Max(array1.Length, array2.Length)];
            int[] sum = new int[numbers1.Length];

            for (int i = 0, j = 0; i < numbers1.Length; i++, j++)
            {
                int k = array1.Length - array2.Length;
                if (k == 0)
                {
                    numbers1[i] = int.Parse(array1[j]);
                    numbers2[i] = int.Parse(array2[j]);
                    sum[i] = numbers1[i] + numbers2[i];
                }
                else if (k > 0)
                {
                    numbers1[i] = int.Parse(array1[i]);

                    if (i % array2.Length == 0) { j = 0; } // var II. Delete this line, take out the "j" from
                                                           //the FOR loop and modify the next line

                    numbers2[i] = int.Parse(array2[j]); // var II. int.Parse(array2[i % array2.Length])

                    sum[i] = numbers1[i] + numbers2[i];

                }
                else
                {
                    numbers2[i] = int.Parse(array2[i]);

                    if (i % array1.Length == 0) { j = 0; } // var II. Delete this line, take out the "j" from 
                                                           //the FOR loop and modify the next line

                    numbers1[i] = int.Parse(array1[j]); //var II. int.Parse(array2[i % array1.Length])

                    sum[i] = numbers1[i] + numbers2[i];

                }


                if (i == (numbers1.Length - 1))
                {
                    Console.WriteLine("{0}", sum[i]);
                }
                else
                {
                    Console.Write("{0} ", sum[i]);
                }

            }
        }
    }
}

