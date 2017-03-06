using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").Split(' ').ToArray();
            string[] text = File.ReadAllText("text.txt")
                .Split(new string[] {" ",",",".","-","?","!",Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, int> freq = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (words[i] == text[j].ToLower())
                    {
                        if (!freq.ContainsKey(words[i]))
                        {
                            freq.Add(words[i],1);
                        }
                        else
                        {
                            freq[words[i]] += 1;
                        }
                    }

                }
            }


            //=========== BEGIN var I
            //string[] result = freq.OrderBy(v => v.Value).Select(a => $"{a.Key} - {a.Value}").ToArray();

            //File.WriteAllLines("Output.txt", result);
            //=========== END var I

            //=========== BEGIN var II
            //
            List<string> toBeOrdered = new List<string>();

            foreach (var item in freq)
            {
                toBeOrdered.Add(item.Value + " " + item.Key);
            }

            toBeOrdered.Sort();
            toBeOrdered.Reverse();

            for (int i = 0; i < toBeOrdered.Count; i++)
            {
                string[] result = toBeOrdered[i].Split(' ');
                string text1 = $"{result[1]} - {result[0]}\n";
            File.AppendAllText("Output.txt", text1);
            }

            //=========== END var II

        }
        }
}
