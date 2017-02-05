using System;
using System.Linq;

namespace _18.SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            if (!(sizeOfArray >= 1 && sizeOfArray <= 15))
            {
                return;
            }

            long[] array = new long[sizeOfArray];

            try
            {
                array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();
            }
            catch (Exception)
            {
                return;               
            }
            
            string[] line = Console.ReadLine().Trim().Split(ArgumentsDelimiter);
            string command = line[0] ;
            int commandsCounter = 1;
            while (!command.Equals("stop"))
            {
                int[] args = new int[2];

                if (commandsCounter > 15)
                {
                    return;
                }

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply") )     //The action can be “multiply”, “add”, “subtract”, “rshift” or “lshift”.
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);

                    if (!(args[0] >= 1 && args[0] <= 10))
                    {
                        return;
                    }

                    if (!(args[1] >=-100 && args[1] <= 100) )
                    {
                        return;
                    }

                    array = PerformAction(array, command, args);
                    PrintArray(array);
                    Console.WriteLine();
                    commandsCounter++;
                }
                else if ( command.Equals("lshift"))
                {
                    array = ArrayShiftLeft(array);
                    PrintArray(array);
                    Console.WriteLine();
                    commandsCounter++;
                }
                else if (command.Equals("rshift") )
                {
                    array = ArrayShiftRight(array);
                    PrintArray(array);
                    Console.WriteLine();
                    commandsCounter++;
                }

                line = Console.ReadLine().Trim().Split(ArgumentsDelimiter);
                command = line[0];

            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
            return array;
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long last = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i>0)
                {
                    array[i] = array[i - 1];
                }
                else
                {
                    array[i] = last;
                }
            }

            return array;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long first = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    array[i] = array[i + 1];
                }
                else
                {
                    array[i] = first;
                }
            }

            return array;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
