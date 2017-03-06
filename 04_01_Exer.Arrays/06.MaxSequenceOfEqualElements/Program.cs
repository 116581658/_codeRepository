using System;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Trim().Split(' ');
            int[] num = new int[text.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(text[i]);
            }


            int index = 0;
            int countLen = 1;
            int bestLen = 1;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i] != num[j])
                    {
                        countLen = 1;
                        i = j - 1;
                        break;
                    }
                    else if (num[i] == num[j])
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
