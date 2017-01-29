using System;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            uint uniqueId = uint.Parse(Console.ReadLine());

            if ((age >= 0 && age <= 100)
                && (gender == 'm' || gender == 'f')
                && (personalId.ToString().Length == 10)
                && (uniqueId >= 27560000 && uniqueId <= 27569999))
            {
                Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\n" +
                    "Gender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firstName, lastName, age, gender, personalId, uniqueId);
            }

        }
    }
}
