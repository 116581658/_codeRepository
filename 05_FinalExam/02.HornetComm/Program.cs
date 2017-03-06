using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ firstQuery} <-> { secondQuery}

            //Private message: If the "first query" consists ONLY of digits and the "second" one consists of DIGITS and / or LETTERS.
            //"first" query is the recipient’s code,  => REVERSE
            //"second query" is the message. 
            //RESULT:  => "second query" -> "first query"


            //Broadcast: If the "first query" consists of anything but digits, and the "second" one consists of letters and / or digits
            //"first" query is the message. 
            //"second query" is the frequency. => Small to UPPERCASE AND Upper to SMALL
            // RESULT: "second query" -> "first query"

            //Any input that does NOT follow the format, specified above, should be IGNORED. 

            // You must keep all input broadcasts and messages after you decrypt them.

            // command “Hornet is Green”, END


            string command = Console.ReadLine();

            string privatePatternOnlyDigits = @"\b(\d+)\b";
            string privatePatternDigitsAndOrLetters = @"\b(\d+\w+)|(\w+)|(\d+)\b";
            string broadPatternNoDigits = @"([^\d\w\r\n\@]+)";  // NOT!
            string broadLettersOrDigits = @"\b(\d+\w+)|(\w+)|(\d+)\b";

            Regex regexPrivFirst = new Regex(privatePatternOnlyDigits);
            Regex regexPrivSecond = new Regex(privatePatternDigitsAndOrLetters);
            Regex regexBroadFirst = new Regex(broadPatternNoDigits);
            Regex regexBroadSecond = new Regex(broadLettersOrDigits);


            List<string> privateStoreCommands = new List<string>();
            List<string> broadStoreCommands = new List<string>();
            List<string> reversedText = new List<string>();
            string transform = "";
            List<string> splitedcommands = new List<string>();
            while (command != "Hornet is Green")
            {
                splitedcommands = command.Trim().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                bool privFirstValidDate = regexPrivFirst.IsMatch(splitedcommands[0]);
                bool privsecondValidDate = regexPrivSecond.IsMatch(splitedcommands[1]);
                bool broadFirstValidDate = regexBroadFirst.IsMatch(splitedcommands[0]);
                bool broadsecondValidDate = regexBroadSecond.IsMatch(splitedcommands[1]);

                if (privFirstValidDate && privsecondValidDate)
                {
                    transform = ReverseString(splitedcommands[0]);
                    string message = "" + (transform) + " -> " + (splitedcommands[1]);

                    privateStoreCommands.Add(message);
                }
                else if (broadFirstValidDate && broadsecondValidDate)
                {
                    transform = UpperToLowerAndVersa(splitedcommands[1], true, true);
                    string message = "" + (transform) + " -> " + (splitedcommands[0]);

                    broadStoreCommands.Add(message);
                }



                command = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadStoreCommands.Count != 0)
            {

                foreach (var item in broadStoreCommands)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (privateStoreCommands.Count != 0)
            {

                foreach (var item in privateStoreCommands)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("None");
            }

        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string UpperToLowerAndVersa(string text, bool toUpper, bool toLower)
        {
            StringBuilder sb = new StringBuilder();
            bool uppercase = toUpper;
            bool lowercase = toLower;
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(char.ToLower(c));
                }
                else
                {
                    sb.Append(char.ToUpper(c));

                }

            }

            string newString = sb.ToString();
            return newString;
        }
    }
}
