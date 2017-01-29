using System;

namespace _02.CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            decimal areaVar1 = (decimal)(Math.PI)* (decimal)( r * r);
           // Console.WriteLine("  Decimal #: {0:#0.0###########}", area1);
           // Console.WriteLine("Decimal f12: {0:f12}", areaVar1);
            Console.WriteLine("{0:f12}", areaVar1);

            // Console.WriteLine("Decimal Math.Round: {0}", Math.Round(areaVar1, 12) );

            // double area2 = (Math.PI * r * r);
            // Console.WriteLine("Double: {0:#0.0###########}", area2);
            // Console.WriteLine("Double f12: {0:f12}", area2);
            // Console.WriteLine("Double Math.round: {0}", Math.Round(area2, 12));
            // Console.WriteLine("Double f12: {0:f12}", area2);

        }
    }
}
