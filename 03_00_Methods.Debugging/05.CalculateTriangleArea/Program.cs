using System;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width,height);
            Console.WriteLine(area);
        }


        static double CalculateTriangleArea(double foundation, double height)
        {
            return ((foundation * height)/2);
        }

    }
}
