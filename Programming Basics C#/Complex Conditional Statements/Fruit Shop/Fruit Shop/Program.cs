﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            var quantity = double.Parse(Console.ReadLine());
            if (fruit != "orange" && fruit != "apple" && fruit != "banana" && fruit != "kiwi" && fruit != "grapes" && fruit != "grapefruit" && fruit != "pineapple")
            { Console.WriteLine("error"); }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "grapes") price = 4.20;
                else if (fruit == "pineapple") price = 5.60;
                quantity = price * quantity;
                Console.WriteLine("{0:f2}", quantity);
            }
            else if (day == "Monday" || day == "Tuesday" || day ==
            "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "grapes") price = 3.85;
                else if (fruit == "pineapple") price = 5.50;
                quantity = quantity * price;
                Console.WriteLine("{0:f2}", quantity);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
