using System;

//seq[0] = 1
//seq[1] = seq[0];
//seq[2] = seq[0] + seq[1];
//seq[3] = seq[0] + seq[1] + seq[2];
//seq[4] = seq[1] + seq[2] + seq[3];
//seq[5] = seq[2] + seq[3] + seq[4];
//seq[6] = seq[3] + seq[4] + seq[5];

namespace _03.LastKNumbersSums
{
    public class LastKNumbersSums
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] seq = new long[n];

            for (long i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    seq[0] = 1;
                }
                else if (i <= k)
                {
                    for (long j = 0; j < i; j++)
                    {
                        seq[i] += seq[j];
                    }
                }
                else
                {
                    for (long j = i - k; j < i; j++)
                    {
                        seq[i] += seq[j];
                    }
                }

                if (i < n - 1)
                {
                    Console.Write("{0} ", seq[i]);
                }
                else
                {
                    Console.WriteLine("{0}", seq[i]);
                }

            }
        }
    }
}
