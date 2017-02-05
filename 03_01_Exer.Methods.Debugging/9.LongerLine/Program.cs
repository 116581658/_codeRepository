using System;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            double line1Length = Math.Round(GetLineLength(x1, y1, x2, y2), 5);
            double line2Length = Math.Round(GetLineLength(x3, y3, x4, y4), 5);

            double distance1 = Math.Round(DetDistance(x1, y1), 5);
            double distance2 = Math.Round(DetDistance(x2, y2), 5);
            double distance3 = Math.Round(DetDistance(x3, y3), 5);
            double distance4 = Math.Round(DetDistance(x4, y4), 5);


            if (line1Length >= line2Length)
            {
                if (distance1 <= distance2)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);

                }
                else
                {
                    Console.WriteLine("({2}, {3})({0}, {1})", x1, y1, x2, y2);

                }
            }
            else
            {
                if (distance3 <= distance4)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);

                }
                else
                {
                    Console.WriteLine("({2}, {3})({0}, {1})", x3, y3, x4, y4);

                }
            }

        }

        public static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return lineLength;

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
