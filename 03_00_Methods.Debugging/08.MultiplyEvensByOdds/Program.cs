using System;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //1234455
            var integ = int.Parse(Console.ReadLine());
            int multiplication = CalcNumber(integ);
            Console.WriteLine(multiplication);
        }

        static int CalcNumber(int number)
        {
            int value = Math.Abs(number);

            int sumOdd = 0;
            int sumEven = 0;
            int reminder = 0;

            while (value > 0)
            {
                reminder = value % 10;

                if (reminder % 2 ==1 )
                {
                    sumOdd += reminder;
                }
                else
                {
                    sumEven += reminder;
                }
                value /= 10;
            }

            return sumOdd * sumEven;

        }

    }
}
