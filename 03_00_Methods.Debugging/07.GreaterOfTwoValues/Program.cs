using System;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type.Equals("int"))
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type.Equals("char"))
            {
                var a = char.Parse(Console.ReadLine());
                var b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type.Equals("string"))
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine(max);
            }

        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>=0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
