using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var min = 100000;
            for (var i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (min > num)
                    min = num;
            }
            Console.WriteLine(min);
        }
    }
}
