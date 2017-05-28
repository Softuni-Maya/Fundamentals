using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main()
        {
            //Calculate how many courses will be needed to transport n persons by using 3 vehicles of capacity 4, 8 and
            // 12 respectively.The input holds one line: the number of people n.The vehicles can travel at the same
            //time..

            int people = int.Parse(Console.ReadLine());
            int capacity = 4 + 8 + 12;
            var courses =(int) Math.Ceiling((double)people / capacity);
            Console.WriteLine(courses);

        }
    }
}
