using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolen = Console.ReadLine();

            if (Convert.ToBoolean(boolen))
            {
                Console.WriteLine("{0}", "Yes");
            }
            else
            {
                Console.WriteLine("{0}", "No");
            }
        }
    }
}
