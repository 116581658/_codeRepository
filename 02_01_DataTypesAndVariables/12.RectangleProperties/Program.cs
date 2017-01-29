using System;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            float perimeter = (float)(width + height) * 2;
            float area = (float)((width * height));
            double diagonal = Math.Sqrt((double)((width * width) + (height * height)));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
