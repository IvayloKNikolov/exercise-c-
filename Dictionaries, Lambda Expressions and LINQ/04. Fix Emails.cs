using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            while (true)
            {
                string person = Console.ReadLine();
                if (person == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                if (!email.Contains(".us") || !email.Contains(".uk"))
                {
                    emails.Add(person, email);
                }
            }
            foreach (var person in emails)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}