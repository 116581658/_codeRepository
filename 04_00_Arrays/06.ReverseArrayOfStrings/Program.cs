using System;

namespace _06.ReverseArrayOfStrings
{
    public class ReverseArrayOfStrings
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Trim().Split(' ');
            string[] reversed = new string[array.Length];

            for (int i = 0; i <= reversed.Length/2; i++)
            {
                reversed[i] = array[reversed.Length - 1 -i];
                reversed[reversed.Length - 1 - i] = array[i];
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                if (i == (reversed.Length -1))
                {
                    Console.WriteLine("{0}", reversed[i]);
                }
                else
                {
                    Console.Write("{0} ", reversed[i]);
                }
            }
        }
    }
}
