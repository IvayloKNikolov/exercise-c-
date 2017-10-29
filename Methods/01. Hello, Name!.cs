using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void printName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            string name = Console.ReadLine();
            printName(name);
        }
    }
}
