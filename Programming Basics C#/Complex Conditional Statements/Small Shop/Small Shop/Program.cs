using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffee = "coffee", water = "water", beer = "beer", sweets = "sweets", peanuts = "peanuts";
            string product = Console.ReadLine();
            string Sofia = "Sofia", Varna = "Varna", Plovdiv = "Plovdiv";
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (town == Varna)
            {
                if (product == coffee) Console.WriteLine(0.45 * quantity);
                if (product == water) Console.WriteLine(0.70 * quantity);
                if (product == beer) Console.WriteLine(1.10 * quantity);
                if (product == sweets) Console.WriteLine(1.35 * quantity);
                if (product == peanuts) Console.WriteLine(1.55 * quantity);
            }
            if (town == Sofia)
            {
                if (product == coffee) Console.WriteLine(0.50 * quantity);
                if (product == water) Console.WriteLine(0.80 * quantity);
                if (product == beer) Console.WriteLine(1.20 * quantity);
                if (product == sweets) Console.WriteLine(1.45 * quantity);
                if (product == peanuts) Console.WriteLine(1.60 * quantity);
            }
            if (town == Plovdiv)
            {
                if (product == coffee) Console.WriteLine(0.40 * quantity);
                if (product == water) Console.WriteLine(0.70 * quantity);
                if (product == beer) Console.WriteLine(1.15 * quantity);
                if (product == sweets) Console.WriteLine(1.30 * quantity);
                if (product == peanuts) Console.WriteLine(1.50 * quantity);
            }
        }
    }
}
