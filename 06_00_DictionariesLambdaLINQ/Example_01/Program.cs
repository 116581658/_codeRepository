using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phonebook = new Dictionary<string, string>();

            phonebook["John Smith"] = "+1-234-2232";
            phonebook["Elsa Smith"] = "+1-234-2232";
            phonebook["Sam Doe"] = "+1-234-2332";
            phonebook["Nakov"] = "+359-7634-2232";
            phonebook["Nakov"] = "+359-8934-2232";

            foreach (KeyValuePair<string,string> item in phonebook)
            {
                Console.WriteLine(item.Value);
            }

            phonebook.Remove("John Smith");
            foreach (KeyValuePair<string, string> item in phonebook)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
