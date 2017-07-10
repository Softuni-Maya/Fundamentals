using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();



            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)

                    Console.WriteLine("Yes");
                if (array[i] != i)
                    Console.WriteLine("No");

            }
             
            
               
            
            
        }
    }
}
