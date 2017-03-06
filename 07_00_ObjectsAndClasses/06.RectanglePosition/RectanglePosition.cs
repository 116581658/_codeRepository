using System;
using System.Linq;

namespace _06.RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            string[] coordinates1 = Console.ReadLine().Trim().Split().ToArray();
            string[] coordinates2 = Console.ReadLine().Trim().Split().ToArray();

            Rectangle r1 = DefineRectangle(coordinates1);
            Rectangle r2 = DefineRectangle(coordinates2);

            if (IsInsideR2(r1,r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }
        //left, top, width and height

        public static Rectangle DefineRectangle(string[] coord)
        {
            Rectangle rect = new Rectangle();
            rect.Left = int.Parse(coord[0]);
            rect.Top = int.Parse(coord[1]);
            rect.Width = int.Parse(coord[2]);
            rect.Heigh = int.Parse(coord[3]);

            return rect;
        }

        public static bool IsInsideR2(Rectangle r1, Rectangle r2)
        {
            bool result = 
                (r1.Left >= r2.Left) 
                && (r1.Right <= r2.Right) 
                && (r1.Top <= r2.Top) 
                && (r1.Bottom <= r2.Bottom);

            return result;
        }

    }





}
