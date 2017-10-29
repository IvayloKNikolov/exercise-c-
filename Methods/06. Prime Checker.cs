using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number == 1)
            {
                Console.WriteLine(false);
            }
            else
            {
                if (isPrime(number))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

       static bool isPrime(int n)
        {
            int k = 2;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    return false;
                }
                k++;
            }
            return true;
        }
    }
}

