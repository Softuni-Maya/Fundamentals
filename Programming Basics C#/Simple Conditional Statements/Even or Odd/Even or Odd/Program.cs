using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
