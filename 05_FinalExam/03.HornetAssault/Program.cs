using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Trim()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> hornets = Console.ReadLine().Trim()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> survived = SurvivedHives(beehives, hornets);
            List<long> resultText = new List<long>();

            foreach (var item in survived)
            {
                if (item != 0)
                {
                    resultText.Add(item);
                }
            }

            

            Console.WriteLine(string.Join(" ", resultText));

        }


        public static List<long> SurvivedHives(List<long> beens, List<long> hornsets)
        {
 
            List<long> arrBeen = beens;
            List<long> arrHornsets = hornsets;

            long summedPowerHornset = SumUsingForeach(arrHornsets);
            int j = 0;
            for (int i = 0; i < arrBeen.Count(); i++)
            {

                long diff = arrBeen[i];
                if (summedPowerHornset > diff)
                {
                    arrBeen[i] = 0;
                }
                else
                {
                    if (i <= arrBeen.Count())
                    {
                        arrBeen[i] = diff - summedPowerHornset;
                        arrHornsets[j] = 0;
                        summedPowerHornset = arrHornsets.Sum();
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

            }


            bool hasAliveBees = SumUsingForeach(arrBeen) != 0L;

            if (hasAliveBees)
            {
                return arrBeen;
            }
            else
            {
                return arrHornsets;

            }
        }

        public static long SumUsingForeach(List<long> longArr)
        {
            var sum = 0L;
            foreach (long num in longArr)
            {
                sum += num;
            }
            return sum;
        }
    }
}
