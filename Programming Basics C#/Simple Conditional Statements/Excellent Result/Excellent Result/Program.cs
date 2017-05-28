using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            if (n >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
