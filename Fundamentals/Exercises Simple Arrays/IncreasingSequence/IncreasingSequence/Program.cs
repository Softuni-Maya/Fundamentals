using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            bool increasing = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] <= numbers[i])
                {
                    increasing = false;
                }
                
            }
            if (increasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
