using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine(a);
        }
    }
}
