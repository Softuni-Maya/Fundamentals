using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());
            string m = (Console.ReadLine());
            n = n.ToLower();
            m = m.ToLower();
            if (n == m)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
