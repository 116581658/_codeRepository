using System;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            double calculation = CalculatePower(number, power);
            Console.WriteLine(calculation);
        }

        static double CalculatePower(double number, int power)
        {
            double result = 1;

            if (power == 0)
            {
                return result;
            }
            else
            {
                for (int i = 1; i <= power; i++)
                {
                    result *= number;
                }

                return result;

            }

        }

    }
}
