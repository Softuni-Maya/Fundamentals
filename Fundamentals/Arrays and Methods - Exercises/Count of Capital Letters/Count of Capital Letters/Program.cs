using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if (character >= 'A' && character <= 'Z')
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
