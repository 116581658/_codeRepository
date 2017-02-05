using System;

namespace _11.GeometryCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            double value = 0;
            if (figureType.Equals("triangle"))
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                value = GetTriangleArea(side, height);
            }
            else if (figureType.Equals("square"))
            {
                var side = double.Parse(Console.ReadLine());
                value = GetSquareArea(side);
            }
            else if (figureType.Equals("rectangle"))
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                value = GetRectangleArea(width, height);
            }
            else if (figureType.Equals("circle"))
            {
                var radius = double.Parse(Console.ReadLine());
                value = GetCircleArea(radius);
            }

            Console.WriteLine("{0:f2}",value);
        }


        public static double GetTriangleArea(double side, double height)
        {
            return Math.Round(side * (height/2),2);
        }

        public static double GetSquareArea(double side)
        {
            return Math.Round((side * side),2);
        }

        public static double GetRectangleArea(double side, double height)
        {
            return Math.Round((side * height),2);
        }

        public static double GetCircleArea(double r)
        {
            return Math.Round((Math.PI * r * r),2);
        }


    }
}
