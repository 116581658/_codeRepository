using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices -1 ; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double priceDifference = CalculatePriceDifferencePercent(previousPrice, currentPrice);
                bool isSignificantDifferent = HasDifference(priceDifference, significanceThreshold);

                string message = PrintResult(previousPrice, currentPrice, priceDifference, isSignificantDifferent);
                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }


        private static string PrintResult(double oldPrice, double newPrice, double difference, bool hasDiff)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (!hasDiff)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, newPrice, difference);
            }
            else if (hasDiff && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, newPrice, difference);
            }
            else if (hasDiff && (difference < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, newPrice, difference);
            }
            return to;
        }

        private static bool HasDifference(double deviationValue, double baseForComparison)
        {
            if (Math.Abs(deviationValue/100) >= baseForComparison)
            {
                return true;
            }
            return false;
        }

        private static double CalculatePriceDifferencePercent(double oldPrice, double newPrice)
        {
            return ((newPrice - oldPrice) / oldPrice)* 100 ;
        }
    }
}
