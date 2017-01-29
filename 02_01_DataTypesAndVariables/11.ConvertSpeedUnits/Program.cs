using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int MILE = 1609;  //  1 mile = 1609 meters.
            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / MILE;
            // S = V * t ; V = S/t
            int hoursMinSecInSeconds = ((hours * 60) * 60) + (minutes * 60) + seconds;
            float secondsMinHoursInHours = hours + ((float)minutes / 60) + ((float)seconds / 3600);

            float metersPerSecond = (distanceInMeters / hoursMinSecInSeconds);
            float kiloPerHour = (float)(distanceInKilometers / secondsMinHoursInHours);
            float milesPerHour = (float)(distanceInMiles / secondsMinHoursInHours);

            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kiloPerHour);
            Console.WriteLine("{0}", milesPerHour);

        }
    }
}
