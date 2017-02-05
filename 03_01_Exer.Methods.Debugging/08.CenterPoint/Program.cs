using System;

namespace _08.CenterPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double distance1 = Math.Round( DetDistance(x1, y1),5);
            double distance2 = Math.Round( DetDistance(x2, y2), 5);

            if (distance1 > distance2)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }

        }

        public static double DetDistance(double x1, double y1)
        {
            double x1Positive = Math.Abs(x1);
            double y1Positive = Math.Abs(y1);
            double distance = Math.Sqrt(x1Positive * x1Positive + y1Positive * y1Positive);

            return distance;
        }

    }
}
