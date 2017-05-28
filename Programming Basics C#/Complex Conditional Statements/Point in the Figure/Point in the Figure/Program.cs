using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var Figure1x = 0;
            var Figure1x2 = 3 * h;
            var Figure1y = 0;
            var Figure1y2 = h;

            var Figure2x = h;
            var Figure2x2 = 2 * h;
            var Figure2y = h;
            var Figure2y2 = 4 * h;

            if (x < 0 || y < 0)
            // първо проверяваме дали стойностите са в рамките на фигурата ни винаги x и y = 0, ако са по-малки значи и точката
            // ще е извън фигурата
            { Console.WriteLine("outside"); }
            else if (x > Figure1x2)
            // проверяваме дали по х не излзиа извън максималната рамка 2*h
            {
                Console.WriteLine("outside");
            }
            else if (y > Figure2y2)
            {
                // проверяваме дали по y не излзиа извън максималната рамка 4*h
                Console.WriteLine("outside");
            }
            else if (x > h && x < 2 * h && (y == Figure1y2 || y == Figure2y))
            // когато х е между 2-4 и y = на първия квадрат
            {
                Console.WriteLine("inside");
            }
            else if (x > h && x < 2 * h && y == Figure2y2)
            // когато х е между 2 и 4, но се намира на горния ръб на вотрата фигура
            {
                Console.WriteLine("border");
            }
            else if ((x == Figure1x || x == Figure1x2) && (y >= Figure1y && y <= Figure1y2))
            // когато х лежи  на х на долната фигура а y е на у на долната фигура
            {
                Console.WriteLine("border");
            }
            else if ((x == Figure2x || x == Figure2x2) && (y >= Figure2y && y <= Figure2y2))
            {
                // х е на 2 или 4 на горната фигура и се намира на точка по у
                Console.WriteLine("border");
            }
            else if ((y == Figure1y || y == Figure1y2) && (x >= Figure1x || x <= Figure1x2))
            {
                //когато у се намиа на у, а х е между 2 и 4 на долната фигура
                Console.WriteLine("border");
            }
            else if ((y == Figure2y && y == Figure2y2) && (x >= Figure1x && x <= Figure1x2))
            {
                //когато у се намра на у, а х е между 2 и 4 на долната фигура
                Console.WriteLine("border");
            }
            else if ((x > Figure1x && x < Figure1x2) && (y > Figure1y && y < Figure1y2))
            {
                // проверка дали се намира вътре в долната фигурата всичко трябва да е налице
                Console.WriteLine("inside");
            }
            else if ((x > Figure2x && x < Figure2x2) && (y > Figure2y && y < Figure2y2))
            {
                // проверка дали се намира вътре в горната фигура
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
