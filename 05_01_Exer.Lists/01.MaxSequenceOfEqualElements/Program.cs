using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> text = Console.ReadLine().Trim().Split(' ').ToList();
            List<int> num = new List<int>();

            for (int i = 0; i < text.Count(); i++)
            {
                string te = text[i];
                num.Add(int.Parse(text[i]));
            }


            int index = 0;
            int countLen = 1;
            int bestLen = 1;
            for (int i = 0; i < num.Count; i++)
            {

                for (int j = i + 1; j <= num.Count; j++)
                {
                    int previous = num[i];
                    int next = 0;

                    if (j < num.Count)
                    {
                        next = num[j];
                    }
                    else
                    {
                        next = previous + 100;
                    }

                    if (previous != next)
                    {
                        countLen = 1;
                        i = j - 1;
                        break;
                    }
                    else if (previous == next)
                    {
                        countLen++;
                        if (bestLen < countLen)
                        {
                            bestLen = countLen;
                            index = i;
                        }
                    }

                }

                countLen = 1;
            }


            for (int i = index; i < index + bestLen; i++)
            {
                if (i == index + bestLen - 1)
                {
                    Console.WriteLine("{0}", num[i]);
                    break;
                }
                else
                {
                    Console.Write("{0} ", num[i]);
                }
            }

        }
    }
}
