using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}
