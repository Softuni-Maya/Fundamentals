using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var secs = sec1 + sec2 + sec3;
            var mins = 0;
            if (secs < 59)
            {
                if (secs < 10)
                {
                    Console.WriteLine("0:0" + secs);
                }
                else
                {
                    Console.WriteLine("0:" + secs);
                }
            }
            if (secs >= 60 && secs <= 119)
            {

                mins++; secs = secs - 60;
                if (secs < 10)
                {
                    Console.WriteLine(1 + ":" + "0" + secs);
                }
                else
                {
                    Console.WriteLine(1 + ":" + secs);
                }
            }
            if (secs > 119 && secs < 177)
            {
                mins++; secs = secs - 120;
                if (secs < 10)
                {
                    Console.WriteLine(2 + ":" + "0" + secs);
                }
                else
                {
                    Console.WriteLine(2 + ":" + secs);
                }
            }

        }
    }
}
