using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (n % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (n % 10 == 5)
            {
                bonus = bonus + 2;
            }
            if (n < 100)
            {
                Console.WriteLine(bonus = bonus + 5);
                Console.WriteLine(n + bonus);
            }

            if (n > 100 && n < 1000)
            {
                Console.WriteLine(bonus = bonus + n * 0.2);
                Console.WriteLine(n + bonus);
            }
            if (n > 1000)
            {
                Console.WriteLine(bonus = bonus + n * 0.1);
                Console.WriteLine(n + bonus);
            }
        }
    }
}
