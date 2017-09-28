<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string pluralNoun = Console.ReadLine();
            if (pluralNoun.EndsWith("y"))
            {
                pluralNoun = pluralNoun.Remove(pluralNoun.Length - 1);
                pluralNoun = pluralNoun + "ies";
            }

            else if (pluralNoun.EndsWith("o") || pluralNoun.EndsWith("x") || pluralNoun.EndsWith("s") || pluralNoun.EndsWith("z") || pluralNoun.EndsWith("ch") || pluralNoun.EndsWith("sh"))
            {
                pluralNoun = pluralNoun + "es";
            }
            else
            {
                pluralNoun = pluralNoun + "s";
            }


            Console.WriteLine(pluralNoun);




        }
}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string pluralNoun = Console.ReadLine();
            if (pluralNoun.EndsWith("y"))
            {
                pluralNoun = pluralNoun.Remove(pluralNoun.Length - 1);
                pluralNoun = pluralNoun + "ies";
            }

            else if (pluralNoun.EndsWith("o") || pluralNoun.EndsWith("x") || pluralNoun.EndsWith("s") || pluralNoun.EndsWith("z") || pluralNoun.EndsWith("ch") || pluralNoun.EndsWith("sh"))
            {
                pluralNoun = pluralNoun + "es";
            }
            else
            {
                pluralNoun = pluralNoun + "s";
            }


            Console.WriteLine(pluralNoun);




        }
}
}
>>>>>>> e574040e142070b9f4e77f217e7bf986e117f2c8
