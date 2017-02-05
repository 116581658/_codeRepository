using System;

namespace _01.HelloName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var theName = Console.ReadLine();
            PrintName(theName);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
