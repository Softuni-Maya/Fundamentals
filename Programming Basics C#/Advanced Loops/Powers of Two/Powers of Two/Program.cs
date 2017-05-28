using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            { Console.WriteLine(num); }
            for (int i = 1; i <= n; i++)

            {
                num = num * 2;
                Console.WriteLine(num);
            }
        }
    }
}
