using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();

            string pattern = "d-M-yyyy";

            DateTime date = DateTime.ParseExact(dateAsText, pattern, CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
