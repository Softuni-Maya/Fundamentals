using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesOfLargerNumbers
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
