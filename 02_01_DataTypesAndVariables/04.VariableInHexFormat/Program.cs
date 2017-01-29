using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHex  = Console.ReadLine();

            int hexToDec = Convert.ToInt32(numberInHex, 16);
            Console.WriteLine(hexToDec);
        }
    }
}
