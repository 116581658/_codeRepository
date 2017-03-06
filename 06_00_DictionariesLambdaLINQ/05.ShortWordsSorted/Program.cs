using System;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] separators = new char[] { '.', ',', ':' ,';' ,'(',  ')', '[', ']' ,'\"'
                ,'\'', '\\', '/' ,'!' ,'?' ,' '};

            string[] text = Console.ReadLine()
                 .Trim()
                 .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                 .Select(t => t.ToLower())
                 .Distinct()
                 .Where(w => w.Length < 5)
                 .OrderBy(p => p.Substring(0))
                 .ToArray();


            Console.WriteLine(string.Join(", ", text));

        }
    }
}
