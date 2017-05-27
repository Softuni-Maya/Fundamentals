using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static void Main()
        {
            string something = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            RepeatString(something,number);

        }
        static void RepeatString(string somthing , int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(somthing);
            }
            Console.WriteLine();
        }
    }
}
