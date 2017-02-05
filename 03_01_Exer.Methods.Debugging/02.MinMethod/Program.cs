using System;

namespace _02.MinMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            int theBiggest = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(theBiggest);

        }

        
        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
