using System;

namespace _05.RoundingNumbersAwayFromZero
{
    public class RoundingNumbersAwayFromZero
    {
        public static void Main(string[] args)
        {
            string text = (Console.ReadLine());
            string[] textTonumbers = text.Trim().Split(' ');
            double[] array = new double[textTonumbers.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(textTonumbers[i]);
                Console.WriteLine("{0} => {1} ", array[i], Math.Round(array[i], MidpointRounding.AwayFromZero));
            }

        }
    }
}
