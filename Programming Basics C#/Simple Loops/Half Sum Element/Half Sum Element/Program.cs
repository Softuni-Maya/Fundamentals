using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (m > max)
                    max = m;
                sum = sum + m;

            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine("Diff ={0} ", Math.Abs(max - sum));
            }
        }
    }
}
