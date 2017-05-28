using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string ftm = "dd-MM-yyyy";
            string value = Console.ReadLine();
            DateTime userBirthday = DateTime.ParseExact(value, ftm, null);
            Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
