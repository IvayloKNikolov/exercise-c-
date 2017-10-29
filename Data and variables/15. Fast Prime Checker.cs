using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int begin = 2; begin <= input; begin++)
{
                bool isPrime = true;
                for (int delimeter = 2; delimeter<= Math.Sqrt(begin); delimeter++)
{
                    if (begin % delimeter == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{begin} -> {isPrime}");
                
            }
        }
    }
}
