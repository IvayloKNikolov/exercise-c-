using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string toRegex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";

            var regexemails = new Regex(toRegex);
            string textToMatch = Console.ReadLine();

            var content = regexemails.Matches(textToMatch);

            foreach (Match mail in content)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
