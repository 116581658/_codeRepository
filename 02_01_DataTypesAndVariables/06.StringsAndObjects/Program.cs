using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;

            string third = (string) helloWorld;
            Console.WriteLine(third);

        }
    }
}
