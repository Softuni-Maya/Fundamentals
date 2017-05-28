using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            min = min + 15;
            if (min <= 59)
            {
                if (min < 10)
                {
                    Console.WriteLine(hour + ":0" + min);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min);
                }
            }
            if (min >= 60 && min <= 119)
            {

                hour++; min = min - 60;
                if (hour == 24)
                {
                    hour = 0;
                }
                if (min < 10)
                {
                    Console.WriteLine(hour + ":" + "0" + min);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min);
                }
            }
            if (min > 119 && min < 177)
            {
                hour = hour + 2; min = min - 120;
                if (hour == 24)
                { hour = hour - 24; }
                if (min < 10)
                {
                    Console.WriteLine(hour + ":" + "0" + min);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min);
                }
            }
        }
    }
}
