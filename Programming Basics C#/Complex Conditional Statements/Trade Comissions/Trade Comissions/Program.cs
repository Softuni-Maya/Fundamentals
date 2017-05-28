using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            double comission = -1;
            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500) comission = 0.05;
                else if (500 < sales && sales <= 1000) comission = 0.07;
                else if (1000 < sales && sales <= 10000) comission = 0.08;
                else if (sales > 10000) comission = 0.12;
                sales = sales * comission;
                Console.WriteLine("{0:f2}", sales);

            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500) comission = 0.045;
                else if (500 < sales && sales <= 1000) comission = 0.075;
                else if (1000 < sales && sales <= 10000) comission = 0.1;
                else if (sales > 10000) comission = 0.13;
                sales = sales * comission;
                Console.WriteLine("{0:f2}", sales);
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500) comission = 0.055;
                else if (500 < sales && sales <= 1000) comission = 0.08;
                else if (1000 < sales && sales <= 10000) comission = 0.12;
                else if (sales > 10000) comission = 0.145;
                sales = sales * comission;
                Console.WriteLine("{0:f2}", sales);
            }
            else
            { Console.WriteLine("error"); }
        }
    }
}
