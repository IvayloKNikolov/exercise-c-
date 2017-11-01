﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex split = new Regex(@"([a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(\w+)");

            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string start = "";
            string end = "";

            var matcher = split.Matches(firstInput);
            foreach (Match match in matcher)
            {
                start = match.Groups[1].Value.ToString();
                end = match.Groups[2].Value.ToString();
            }

            var solution = new StringBuilder();

            int indexStart = 0;
            int indexEnd = 0;

            for (int i = 0; i < secondInput.Length; i++)
            {
                int firstOccasion = secondInput.IndexOf(start, indexStart);
                if (firstOccasion == -1)
                {
                    break;
                }
                int secondOccasion = secondInput.IndexOf(end, indexEnd);

                if (firstOccasion != -1 && secondOccasion != -1)
                {
                    solution.Append(secondInput, firstOccasion + start.Length, secondOccasion - firstOccasion - start.Length);

                    indexStart = secondOccasion + end.Length;
                    indexEnd = indexStart + 1;
                }
            }
            if (solution.Length > 0)
            {
                Console.WriteLine(solution);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
