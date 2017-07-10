using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var result = RaiseToPower(a, b);
            Console.WriteLine(result);
        }
        static double RaiseToPower(double a, double b)
        {
            var num = Math.Pow(a,b);
            return num;

        }
    }
}
