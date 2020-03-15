using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 7, 8, 9 };
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x > array[i])
                {
                    continue;
                }
                else
                {
                    x = array[i];
                }
            }
            Console.WriteLine("Largest Number = " + x);
            Console.ReadKey();
        }
    }
}
