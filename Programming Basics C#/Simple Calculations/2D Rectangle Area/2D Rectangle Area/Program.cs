using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double a;
            double b;

            if (x1 < x2)
            {
                a = x2 - x1;
            }
            else
            {
                a = x1 - x2;
            }
            if (y1 < y2)
            {
                b = y2 - y1;
            }
            else
            {
                b = y1 - y2;
            }

            var area = a * b;
            var p = 2 * a + 2 * b;

            Console.WriteLine("{0}\n{1}", area, p);
        }
    }
}
