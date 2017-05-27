using System;


namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main()
        {
            double terabytes = double.Parse(Console.ReadLine());
            Console.WriteLine(terabytes * 1024 * 1024 * 1024 * 1024 * 8);
        }
    }
}
