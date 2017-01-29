using System;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingChar = int.Parse(Console.ReadLine());
            int endingChar = int.Parse(Console.ReadLine());

            for (int i = startingChar; i <= endingChar; i++)
            {
                if (i >= startingChar && i < endingChar)
                {
                    Console.Write(((char)i ) + " ");
                }
                else
                {
                    Console.WriteLine(((char)i));
                }
            }

        }
    }
}
