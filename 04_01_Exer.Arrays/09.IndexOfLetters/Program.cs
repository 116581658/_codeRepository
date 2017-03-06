using System;

namespace _09.IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().Trim();
            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", characters[i], ConvertCharToNumbers(characters[i]));
            }

        }

        public static int ConvertCharToNumbers(char letter)
        {
            int i = (int)(letter - 'a');
            return i;
        }
    }
}
