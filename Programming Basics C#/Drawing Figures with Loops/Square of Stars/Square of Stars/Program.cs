using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *", n);
                }
                Console.WriteLine();
            }
        }
    }
}
