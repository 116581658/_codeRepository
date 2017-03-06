using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ',', ';', ':', '.', '!'
                , '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> text = Console.ReadLine().Trim()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> areLowerCase = new List<string>();
            List<string> areMixedCase = new List<string>();
            List<string> areUpperCase = new List<string>();

            for (int i = 0; i < text.Count(); i++)
            {
                string innerText = text[i];
                //double number1 = 0;
                //bool canConvert = double.TryParse(innerText, out number1);

                if (innerText.Equals(innerText.ToLower()) && IsAllLetters(innerText))
                {
                    areLowerCase.Add(innerText);
                }
                else if (innerText.Equals(innerText.ToUpper()) && IsAllLetters(innerText))
                {
                    areUpperCase.Add(innerText);
                }
                else
                {
                    areMixedCase.Add(innerText);
                }
            }


            if (areLowerCase.Count() > 0)
            {
                Console.WriteLine("Lower-case: {0}", string.Join(", ", areLowerCase));
            }

            if (areMixedCase.Count() > 0)
            {
                Console.WriteLine("Mixed-case: {0}", string.Join(", ", areMixedCase));
            }

            if (areUpperCase.Count() > 0)
            {
                Console.WriteLine("Upper-case: {0}", string.Join(", ", areUpperCase));

            }

        }
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
