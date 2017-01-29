using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a,b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);

        }
    }
}
