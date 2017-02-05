using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            string theNumberString = "" + number;
            string reversed = GiveReversed(theNumberString);
            Console.WriteLine(reversed);
        }


        static string GiveReversed(string num)
        {
            string newOrder = string.Empty;

            if (num.Substring(0, 1).Equals("-"))
            {
                num = num.Remove(0, 1);
                newOrder = "-" + ReverseOrder(num);
            }
            else if (num.Substring(0, 1).Equals("+"))
            {
                num = num.Remove(0, 1);
                newOrder = "+" + ReverseOrder(num);
            }
            else
            {
                newOrder = ReverseOrder(num);
            }

            return newOrder;
        }


        static string ReverseOrder(string numberText)
        {
            string reversedOrder = string.Empty;
            string intermediate = string.Empty;
            int stringLength = numberText.Length;
            for (int i = stringLength; i > 0; i--)
            {
                reversedOrder += numberText.Substring(numberText.Length - 1, 1);
                intermediate = numberText.Remove(numberText.Length - 1, 1);
                numberText = intermediate;
            }
            return reversedOrder;
        }
    }
}
