using System;

namespace _10.CubeProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var side = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();

            double calculation = ReturnProperty(side, cubeParameter);

            if (calculation == -1)
            {
                Console.WriteLine("invalid value for property");
            }
            else
            {
                Console.WriteLine("{0:F2}",calculation);
            }

        }

        public static double ReturnProperty(double edge, string cubePropery)
        {
            double value = 0;

            if (cubePropery.Equals("face"))
            {
               value = CalculateFaceDiagonals(edge);
            }
            else if (cubePropery.Equals("space"))
            {
                value = CalculateSpaceDiagonals(edge);
            }
            else if (cubePropery.Equals("volume"))
            {
                value = CalculateVolume(edge);
            }
            else if (cubePropery.Equals("area"))
            {
                value = CalculateArea(edge);
            }
            else
            {
                value = -1;
            }

            return value;
        }

        public static double CalculateFaceDiagonals(double x)
        {
            return Math.Round(Math.Sqrt(2 * x * x),2);
        }

        public static double CalculateSpaceDiagonals(double x)
        {
            return Math.Round(Math.Sqrt(3 * x * x),2);
        }

        public static double CalculateVolume(double x)
        {
            return Math.Round((x * x * x),2);
        }

        public static double CalculateArea(double x)
        {
            return Math.Round((6 * x * x),2);
        }

    }
}
