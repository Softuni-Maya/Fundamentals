using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            for (var i = 1; i <= n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }
            int right = 0;
            for (var i = 1; i <= n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }
            if (left == right)
                Console.WriteLine("Yes, sum = " + left);
            else
                Console.WriteLine("No, diff = " +
               Math.Abs(right - left));
        }
    }
}
