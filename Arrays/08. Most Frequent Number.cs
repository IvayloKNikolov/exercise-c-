using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[65535];
            int maxCount = 0;
            int frequentNumber = 0;
            for( int i = 0; i< sequence.Length;i++)
            {
                count[sequence[i]]++;
                if (count[sequence[i]]>maxCount)
                {
                    maxCount = count[sequence[i]];
                    frequentNumber = sequence[i];
                }
            }
            Console.WriteLine(frequentNumber);
        }
    }
}
