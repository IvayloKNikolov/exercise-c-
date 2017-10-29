﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            byte digit = (byte)Math.Abs(num % 10);
            Dictionary<int, string> dictionaryDigits = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine",
                [0] = "zero"
            };
            Console.WriteLine(dictionaryDigits[digit]);
        }
    }
}
