using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int reminder = numberOfPeople % capacity;

            int courses = 0;
            if (reminder == 0)
            {
                courses = numberOfPeople / capacity;
            }
            else
            {
                courses = (numberOfPeople / capacity) + 1;
            }

            Console.WriteLine(courses);
        }
    }
}
