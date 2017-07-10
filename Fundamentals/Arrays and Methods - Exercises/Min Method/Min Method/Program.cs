using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = GetMin(a,b,c);
            Console.WriteLine(sum);

        }
        private static int GetMin(int a, int b, int c)
        {
            var arr = new int[3];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;

            var min = arr.Min();
            return min;
        }
    }
}
