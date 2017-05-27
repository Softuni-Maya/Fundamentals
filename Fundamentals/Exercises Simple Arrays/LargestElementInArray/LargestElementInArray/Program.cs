using System;
using System.Linq;

namespace LargestElementinArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers.Max();
            Console.WriteLine(max);

        }
    }
}

