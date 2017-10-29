using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, long>();
            long counter = 0;
            string resources = "";

            while (true)
            {
                string current = Console.ReadLine();

                if (current == " stop")
                {
                    break;
                }
                counter++; 
                if (counter % 2 != 0)
                {
                    if (!dictionary.ContainsKey(current))
                    {
                        dictionary[current] = 0;
                    }
                    resources = current;
                }
                if (counter % 2 == 0)
                {
                    dictionary[resources] = long.Parse(current);
                }
            }
            foreach (var recource in dictionary)
            {
                Console.WriteLine("{0} -> {1}", recource.Key, recource.Value);
            }
        }
    }
}
