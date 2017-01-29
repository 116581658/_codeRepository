using System;

namespace _09.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine("{2}{1}{0}", first,second,third);
        }
    }
}
