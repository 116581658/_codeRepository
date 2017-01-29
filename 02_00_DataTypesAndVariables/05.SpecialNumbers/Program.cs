using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i<10)
                {
                    if (i==5 || i == 7 || i == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }
                else
                {
                    int reminder = 0;
                    int sum = 0;
                    int dividend = i;
                    while ( dividend > 0)
                    {
                        reminder = dividend % 10;
                        dividend -= reminder;
                        dividend /= 10;
                        sum += reminder;
                    }

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }

                }
            }

        }
    }
}
