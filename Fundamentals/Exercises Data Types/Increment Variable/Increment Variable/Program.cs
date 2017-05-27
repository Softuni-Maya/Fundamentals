using System;


namespace Increment_Variable
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            byte variable = 0;
            int times = 0;

            for (int i = 0; i < number; i++)
            {
                variable++;

                if (variable == 0)
                {
                    times++;
                }
            }
            Console.WriteLine(variable);
            Console.WriteLine("Overflowed {0} times", times);
        }
    }
}

