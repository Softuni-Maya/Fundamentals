using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string square = "square", rectangle = "rectangle", circle = "circle", triangle = "triangle";
            var x = (Console.ReadLine());
            if (x == square)
            {
                var num = double.Parse(Console.ReadLine());
                var area = num * num;
                Console.WriteLine(area);
            }
            else if (x == rectangle)
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area1 = a * b;
                Console.WriteLine(area1);
            }
            else if (x == circle)
            {
                var r = double.Parse(Console.ReadLine());
                var area2 = (Math.PI * r * r);
                Console.WriteLine(area2);
            }
            else if (x == triangle)
            {
                var n = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area3 = 0.5 * n * h;
                Console.WriteLine(area3);
            }
        }
    }
}
