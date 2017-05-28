using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); //брой празници в годината (които не са събота и неделя).
            int h = int.Parse(Console.ReadLine()); //брой уикенди, в които Влади си пътува до родния град.
            double weekends = 0.0;//уикенди в София
            double gameSofia = 0.0; // игри в София
            double gameCity = h;  //игри в родния град
            double gameP = 0.0;
            double game = 0.0;
            double result = 0.0;

            if (year == "normal")
            {
                weekends = 48 - h;
                gameSofia = weekends * (3.0 / 4);  //игри в София
                gameP = p * (2.0 / 3);           //игри в празничен ден
                game = gameSofia + gameCity + gameP; //общо игри
                Console.WriteLine(Math.Truncate(game));
            }
            else
            {
                weekends = 48 - h;
                gameSofia = weekends * (3.0 / 4);  //игри в София
                gameP = p * (2.0 / 3);           //игри в празничен ден
                game = gameSofia + gameCity + gameP; //общо игри
                result = 0.15 * game;
                game = game + result;
                Console.WriteLine(Math.Truncate(game));
            }
        }
    }
}
