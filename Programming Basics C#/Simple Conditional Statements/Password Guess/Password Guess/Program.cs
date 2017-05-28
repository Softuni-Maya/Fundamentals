using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());
            string b = "s3cr3t!P@ssw0rd";
            if (n == b)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
