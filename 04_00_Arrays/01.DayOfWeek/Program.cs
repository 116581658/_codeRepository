using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberDay = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday"
                    , "Thursday", "Friday", "Saturday", "Sunday"};

            if (numberDay >= 1 && numberDay <= 7)
            {
                Console.WriteLine(daysOfWeek[numberDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
