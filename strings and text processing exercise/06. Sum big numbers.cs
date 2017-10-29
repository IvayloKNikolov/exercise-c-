using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main()  
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine("{0}", first + second);
        }
    }
}
