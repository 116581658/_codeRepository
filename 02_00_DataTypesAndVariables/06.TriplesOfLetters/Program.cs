using System;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char firstLatinSmall = 'a';
            int letter = (int)firstLatinSmall;
            Console.WriteLine("letter" + letter);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstLetter = (char)(letter + i);
                        char secondLetter = (char)(letter + j);
                        char thirdLetter = (char)(letter + k);

                        Console.WriteLine("" + firstLetter + secondLetter + thirdLetter);
                    }
                }
            }
        }
    }
}
