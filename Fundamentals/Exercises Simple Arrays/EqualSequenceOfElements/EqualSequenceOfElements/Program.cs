using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElements
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            bool equally = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    equally = false;
                }

            }
            if (equally)
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
