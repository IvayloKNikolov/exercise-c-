using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumArray = new int[array.Length];

            for (int i = 0; i < rotations; i++)
            {
                RotateArray(array);

                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] = sumArray[j] + array[j];
                }
            }
            Console.WriteLine(String.Join(" ", sumArray));
        }
        private static void RotateArray(int[]array)
        {
            var lastNumber = array.Last();

            for (int i = array.Length-1; i>0; i--)
            {
                array[i] = array[i-1];
            }
            array[0] = lastNumber;
        }
    }
}
