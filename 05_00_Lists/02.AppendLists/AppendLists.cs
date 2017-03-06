using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    public class AppendLists
    {
        public static void Main(string[] args)
        {
            List<string> someText = Console.ReadLine().Trim()
                .Split('|')
                .ToList();

            List<string> reworkedText = new List<string>();

            for (int i = someText.Count() - 1; i >= 0; i--)
            {
                List<string> innerText = someText[i].Trim()
                .Split(' ')
                .ToList();

                for (int j = 0; j < innerText.Count(); j++)
                {
                    if (!innerText[j].Equals(""))
                    {
                        reworkedText.Add(innerText[j]);
                    }
                }

            }


            for (int i = 0; i < reworkedText.Count(); i++)
            {
                if (i < reworkedText.Count() - 1)
                {
                    Console.Write("{0} ", reworkedText[i]);
                }
                else
                {
                    Console.WriteLine("{0}", reworkedText[i]);
                }
            }


        }
    }
}
