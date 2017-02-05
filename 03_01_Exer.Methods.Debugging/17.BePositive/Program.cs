using System;
using System.Collections.Generic;

namespace _17.BePositive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int countSequences = int.Parse(Console.ReadLine()); // [1 … 15]
                if (!(countSequences >= 1 && countSequences <= 15))
                {
                    //Console.WriteLine("The number must be an integer in the range[1 ... 15].");
                    return;
                }

                for (int i = 0; i < countSequences; i++)
                {
                    string[] input = Console.ReadLine().Trim().Split(' ');   //[-1000 … 1000].
                    var numbers = new List<int>();
                    int counterOfNumbers = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        if ((!input[j].Equals(string.Empty)))
                        {
                            try
                            {
                                int number = int.Parse(input[j]);
                                if (!((number >= -1000) && (number <= 1000)))
                                {
                                    // Console.WriteLine("The numbers in the sequences must be integers in the range [-1000 ... 1000].");
                                    return;
                                }

                                int num = int.Parse(input[j]);
                                numbers.Add(num);
                                counterOfNumbers++;

                            }
                            catch (Exception)
                            {
                                return;
                            }

                        }

                        if (counterOfNumbers > 20)
                        {
                           // Console.WriteLine("The count of numbers in each sequence must be in the range [1 ... 20]");
                            return;
                        }
                    }

                    bool found = false;

                    for (int j = 0; j < numbers.Count; j++)
                    {
                        int currentNum = numbers[j];

                        if (currentNum >= 0)
                        {
                            Console.Write(currentNum);
                            Console.Write(" ");
                            found = true;
                        }
                        else
                        {
                            currentNum += numbers[j + 1];

                            if (currentNum >= 0)
                            {
                                Console.Write(currentNum);
                                Console.Write(" ");
                                j++;
                                found = true;
                            }
                            else
                            {
                                j++;
                                found = false;
                            }
                        }

                    }

                    if (!found)
                    {
                        Console.WriteLine("(empty)");
                    }

                    Console.WriteLine();
                }


            }
            catch (Exception)
            {
                return;
            }

        }
    }
}
