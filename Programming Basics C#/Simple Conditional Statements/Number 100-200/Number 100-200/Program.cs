using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            if (n < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (n >= 100 && n <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (n > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
