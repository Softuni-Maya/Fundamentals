using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsAtOddPositions
{
    class Program
    {
        static void Main()
        {
            var someText = Console.ReadLine().Split(' ').ToList();
            var result = new List<string>();

            for (int i = 1; i < someText.Count; i++)
            { 
                if (i % 2 != 0)
                {
                    result.Add(someText[i]);
                }
            }
            Console.WriteLine(String.Join("", result));
        }
    }
}
