using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            { Console.WriteLine(num); }
            for (int i = 2; i <= n; i += 2)

            {
                num = num * 2 * 2;
                Console.WriteLine(num);
            }

        }
    }
}
