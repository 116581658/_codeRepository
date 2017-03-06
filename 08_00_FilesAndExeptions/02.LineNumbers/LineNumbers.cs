using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("Input.txt");

            string[] text = new string[file.Length];
            for (int i = 0; i < file.Length; i++)
            {
                int rowNr = i + 1;
                text[i] = rowNr + ". " + file[i];
            }

            File.WriteAllLines("Output.txt", text);
            //File.Open("Output.txt",FileMode.Open);
            Console.WriteLine(File.ReadAllText("Output.txt"));
        }
    }
}
