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
            int m = n - 2;
            for (int i = 1; i < n; i++)
                Console.Write("*");
            Console.WriteLine("*");
            for (int i = 0; i < n - 2; i++)
                Console.WriteLine("*" + new string(' ', m) + "*");
            for (int i = 1; i < n; i++)
                Console.Write("*");
            Console.WriteLine("*");
        }
    }
}
