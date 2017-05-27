using System;


namespace ExchangeVariableValues
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;

            c = b;
            b = a;
            a = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
