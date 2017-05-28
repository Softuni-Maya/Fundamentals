using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes")
                Console.WriteLine("fruit");
            else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot")
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");
        }
    }
}
