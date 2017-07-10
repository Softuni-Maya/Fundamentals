using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

           var result = IntegerToBase(number, toBase);
            Console.WriteLine(result);
        }
        private static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;
            while (number > 0)
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
