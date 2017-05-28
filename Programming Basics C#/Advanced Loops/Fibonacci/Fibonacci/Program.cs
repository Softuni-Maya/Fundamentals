using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var fi = 1;
            var f0 = 1;
            var f1 = 1;


            for (int i = 1; i < number; i++)
            {
                fi = f0 + f1;

                f0 = f1;
                f1 = fi;

            }
            Console.WriteLine(fi);
        }
    }
}
