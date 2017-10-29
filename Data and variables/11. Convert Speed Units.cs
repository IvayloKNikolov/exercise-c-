using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float km = distance / 1000.0f / hourTime;
            float meters = km / 3.6f;
            float miles = distance / 1609.0f / hourTime;

            Console.WriteLine("{0}", meters);
            Console.WriteLine("{0}", km);
            Console.WriteLine("{0}", miles);
        }
    }
    
}
