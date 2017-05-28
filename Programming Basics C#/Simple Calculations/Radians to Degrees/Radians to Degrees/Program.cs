using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degrees = rad * 180 / Math.PI;
            Console.WriteLine("Dergrees=" + Math.Round(degrees));
        }
    }
    }
}
