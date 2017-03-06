using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            int[] pointsX1Y1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int[] pointsX2Y2 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            Point p1 = new Point();
            Point p2 = new Point();

            p1.X = pointsX1Y1[0];
            p1.Y = pointsX1Y1[1];

            p2.X = pointsX2Y2[0];
            p2.Y = pointsX2Y2[1];

            double distanceP1P2 = CalcDistance(p1, p2);
            Console.WriteLine("{0:F3}", distanceP1P2);

        }

        public static double CalcDistance(Point a, Point b)
        {
            double distance = Math.Sqrt(((a.X - b.X) * (a.X - b.X)) + (a.Y - b.Y) * (a.Y - b.Y));

            return distance;
        }
    }
}
