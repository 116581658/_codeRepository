using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            List<double> intermediate = new List<double>();

            double difference = 0.0001;
            int i = 1;
            while (i < numbers.Count())
            {
                List<double> result = new List<double>();
                double number1 = numbers[i - 1] ;
                double number2 = numbers[i];

                double sum = number1 + number2;

                if (Math.Abs(number1 - number2) < difference)
                {
                    for (int k = 0; k < i - 1; k++)
                    {
                        result.Add(numbers[k]);
                    }

                    result.Add(sum);

                    for (int j = i + 1; j < numbers.Count(); j++)
                    {
                        intermediate.Add(numbers[j]);
                    }

                    result.AddRange(intermediate);
                    numbers = result;
                    intermediate = new List<double>();
                    i = 1;
                }
                else
                {
                    for (int k = 0; k < i; k++)
                    {
                        result.Add(numbers[k]);
                    }

                    for (int j = i; j < numbers.Count(); j++)
                    {
                        intermediate.Add(numbers[j]);
                    }

                    result.AddRange(intermediate);
                    numbers = result;
                    intermediate = new List<double>();
                    i++;
                }
            }

            for (int k = 0; k < numbers.Count(); k++)
            {
                if (k < numbers.Count() - 1)
                {
                    Console.Write("{0} ", numbers[k]);
                }
                else
                {
                    Console.WriteLine("{0}", numbers[k]);
                }
            }

        }
    }
}
