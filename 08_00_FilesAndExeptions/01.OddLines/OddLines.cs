using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {

            string[] file = File.ReadAllLines("Input.txt");
        
            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    string[] line = file[i].Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    File.AppendAllLines("Output.txt", line);
                }
            }

            string outputFile = File.ReadAllText("Output.txt");

            Console.WriteLine(outputFile);
            File.Delete("Output.txt");

        }
    }
}
