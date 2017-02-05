using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fib(n);
            Console.WriteLine(result);

        }


        static int Fib(int n)
        {
            int fib0 = 1;
            int fib1 = 1;
            int fibNext = fib0 + fib1; // = 2

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                while (n >= 3)
                {
                    fib0 = fib1;
                    fib1 = fibNext;
                    fibNext = fib0 + fib1; // = 2

                    n--;
                }
                return fibNext;
            }
        }
    }
}
