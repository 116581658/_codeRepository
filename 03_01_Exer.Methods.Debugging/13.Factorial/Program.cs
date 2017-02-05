using System;
using System.IO;
using System.Numerics;

namespace _13.Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));

            //string starting = "We begin.\r\n";
            //// Write the string to a file.
            //System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Programming\CSharp\CodeRepository\02_Tech_Module\Factorial.txt");
            //file.WriteLine(starting);
            //file.WriteLine(Factorial(number));
            //file.Close();

        }

        public static BigInteger Factorial(int value)
        {

            BigInteger factorial = 1;
            if (value == 1)
            {
                return factorial;
            }
            else
            {
                for (int i = 2; i <= value; i++)
                {
                    factorial *= i;
                }
            }

            return factorial;

        }

    }
}
