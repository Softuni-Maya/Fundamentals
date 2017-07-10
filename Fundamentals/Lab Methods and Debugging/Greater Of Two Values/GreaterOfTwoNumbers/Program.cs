using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }
        static void GetMax()
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = Math.Max(a, b);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                int max = Math.Max(a, b);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string a =Console.ReadLine();
                string b = Console.ReadLine();
                int max = Math.Max(a, b);
                Console.WriteLine(max);
            }
        }
    }
}
