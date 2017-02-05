using System;

namespace _12.MasterNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var range1toN = int.Parse(Console.ReadLine()); 
            ReturnPalindroms(range1toN);
        }


        public static void ReturnPalindroms(int number)
        {
            int palindromDevisor = 7;
            for (int i = 1; i <= number; i++)
            {
                int digitsSum = SumOfDigits(i);
                bool divisableBySeven = digitsSum % palindromDevisor == 0;

                if (divisableBySeven)
                {
                    bool hasEvenDidits = ContainsEvenDigit(i);
                    if (hasEvenDidits)
                    {
                        bool isPalindrom = IsPalindrome(i);
                        if (isPalindrom)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }

            }
        }

        public static bool IsPalindrome(int number)
        {
            bool isPalindrom = false;
            string theNumber = "" + number;
            int thenumberLength = theNumber.Length;
           

            if (thenumberLength == 1)
            {
                isPalindrom = true;
                return isPalindrom;
            }
            else if (thenumberLength > 1)
            {
                int theNumberFirstHalfLength = thenumberLength / 2;
                string firstHalfDigits = theNumber.Substring(0, theNumberFirstHalfLength);
                string secondHalfDigits = theNumber.Substring(theNumberFirstHalfLength);
                if (thenumberLength % 2 != 0)
                {
                    secondHalfDigits = secondHalfDigits.Remove(0, 1);
                }

                string turnedDigits = ReverseOrder(secondHalfDigits);

                if (firstHalfDigits.Equals(turnedDigits))
                {
                    isPalindrom = true;
                }
            }

            return isPalindrom;
        }

        
        public static int SumOfDigits(int num)
        {
            int total = 0;
            while (num > 0)
            {
                total += num % 10;
                num /= 10;
            }

            return total;
        }

        public static bool ContainsEvenDigit(int num)
        {
            bool containsEven = false;
            int lastDigit = 0;
            while (num > 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    containsEven = true;
                    break;
                }
                num /= 10;
            }

            return containsEven;
        }

        static string ReverseOrder(string numberText)
        {
            string reversedOrder = "";
            string intermediate = "";
            int stringLength = numberText.Length;
            int intermediateLength = 0;
            for (int i = stringLength; i > 0; i--)
            {
                intermediateLength = numberText.Length - 1;
                reversedOrder += numberText.Substring(intermediateLength, 1);
                intermediate = numberText.Remove(intermediateLength, 1);
                numberText = intermediate;
                intermediate = "";
            }

            return reversedOrder;
        }

    }
}
