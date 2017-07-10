using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());

            FindNthDigit(number, index);
        }


        static void FindNthDigit(string number, int index)
        {
            char sum = '\0';

            for (int i = 0; i < number.Length; i++)
            {
                sum = number[number.Length - index];
            }
            Console.WriteLine(sum);

        }
    }
}
