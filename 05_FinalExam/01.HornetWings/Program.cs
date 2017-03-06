using System;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlags = int.Parse(Console.ReadLine()); //N [0; 1,000,000,000] 
            double distanceMetersFor1000Flaps = double.Parse(Console.ReadLine());// M [0; 1,000,000]
            int flaps = 1000;    //  meters
            int endurance = int.Parse(Console.ReadLine()); // P [1; N].
            int restForSeconds = 5;
            int wingsPerSecond = 100;

            double distance = ((double)wingFlags / flaps) * distanceMetersFor1000Flaps;
            int distanceInSeconds = wingFlags / wingsPerSecond;
            int restsInSeconds = (wingFlags / endurance) * restForSeconds;
            int totalTimeSeconds = distanceInSeconds + restsInSeconds;

            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.", totalTimeSeconds);

        }
    }
}
