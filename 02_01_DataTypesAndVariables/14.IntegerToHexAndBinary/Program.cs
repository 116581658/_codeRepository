using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());

            string decToHex = Convert.ToString(dec,16).ToUpper();
            string decToBin = Convert.ToString(dec,2);

            Console.WriteLine(decToHex);
            Console.WriteLine(decToBin);
        }
    }
}
