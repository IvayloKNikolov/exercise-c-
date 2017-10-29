﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int middleStartIndex = sequence.Length / 4;
            int middleEndIndex = middleStartIndex + sequence.Length / 2;
            
            int summingIndex = middleStartIndex - 1;

            for (int i = middleStartIndex; i < middleEndIndex; i++)
            {
                int sum = sequence[i] + sequence[summingIndex];
                Console.Write($"{sum} ");
                summingIndex--;
                if (summingIndex < 0)
                {
                    summingIndex = sequence.Length - 1;
                }
            }
        }
    }
}

