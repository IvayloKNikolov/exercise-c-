using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char invalid = char.Parse(Console.ReadLine());
            

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        string final = "" +i+j+k;
                        if (!final.Contains(invalid + ""))
                        {
                            Console.Write(final + " ");
                        }
                    }
                }
            }
        }
    }
}
