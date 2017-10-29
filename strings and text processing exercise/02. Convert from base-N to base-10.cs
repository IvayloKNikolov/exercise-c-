﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = input[0];
            BigInteger number = input[1];
            BigInteger pow = 0;
            BigInteger result = 0;

            while (number > 0)
            {
                BigInteger digit = number % 10;
                BigInteger baseNRaisedToPower = 1;

                if (pow == 0)
                {
                    baseNRaisedToPower = 1;
                }
                else
                {
                    for (int i = 0; i < pow; i++)
                    {
                        baseNRaisedToPower *= baseN;
                    }
                }

                result += digit * baseNRaisedToPower;
                pow++;
                number = number / 10;
            }
            Console.WriteLine(result);
        }
    }
}