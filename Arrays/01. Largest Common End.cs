using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');
            int leftCounter = 0;
            int rightCounter = 0;
            int lenght = Math.Min(first.Length, second.Length);

            for (int i = 0; i < lenght; i++)
            {
                if (first[i] == second[i])
                {
                    leftCounter++;
                }
                if (first[first.Length - i-1] == second[second.Length -i -1])
                {
                    rightCounter++;
                }
          
            }
            Console.WriteLine(Math.Max(leftCounter, rightCounter));

        }
    }
}
