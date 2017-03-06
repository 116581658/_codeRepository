using System;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            Point somePoint = new Point();

            int ind = 0;
            while (n > 0)
            {
                int[] pointXY = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                points[ind] = somePoint;
                somePoint.X = pointXY[0];
                somePoint.Y = pointXY[1];

                somePoint = new Point();
                ind++;
                n--;
            }


            Point[] totalRes = FindClosestPoints(points);
            double minimalDistance = CalcDistance(totalRes[0], totalRes[1]);

            Console.WriteLine("{0:F3}",minimalDistance);
            Console.WriteLine($"({totalRes[0].X}, {totalRes[0].Y})");
            Console.WriteLine($"({totalRes[1].X}, {totalRes[1].Y})");

        }

        public static double CalcDistance(Point a, Point b)
        {
            double distance = Math.Sqrt(((a.X - b.X) * (a.X - b.X)) + (a.Y - b.Y) * (a.Y - b.Y));
            return distance;
        }


        public static Point[] FindClosestPoints(Point[] points) {

            double minDistance = 0;
            double distance = 1;
            Point pointA = new Point();
            Point pointB = new Point();
            bool forFirstTime = true;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {

                    distance = CalcDistance(points[i], points[j]);
                    if (forFirstTime)
                    {
                        minDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                        forFirstTime = false;
                    }


                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                    }

                }
            }

            Point[] result = { pointA, pointB };
            return result;
        }


    }
}


public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
