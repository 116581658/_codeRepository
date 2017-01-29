using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string sometext = Console.ReadLine();

            Boolean convertedSometext = Convert.ToBoolean(sometext);
            if (convertedSometext)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
