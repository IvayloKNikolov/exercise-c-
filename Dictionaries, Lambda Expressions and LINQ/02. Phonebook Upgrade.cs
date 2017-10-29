using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();



                if (command[0] == "A")
                {
                    string name = command[1];
                    string phoneNumber = command[2];

                    phonebook[name] = phoneNumber;
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var name in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", name.Key, name.Value);
                    }
                }


                else if (command[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
