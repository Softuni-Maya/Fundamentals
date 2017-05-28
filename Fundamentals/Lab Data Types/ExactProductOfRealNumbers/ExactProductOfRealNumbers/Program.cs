using System;
using System.Linq;


namespace ExactProductOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 1;
            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum = sum * num;
            }
            Console.WriteLine(sum);
        }
    }
}
