using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenElementInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == element)
                {
                    index++;
                }
            }
            Console.WriteLine(index);
        }
    }
}
