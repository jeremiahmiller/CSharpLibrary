using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix tcats = new Netflix();
            tcats.Name = "Thundercats";
            tcats.Rating = 5.0;
            tcats.Genre = "Cartoon Action";
            tcats.TotalMinutes = 22;
            tcats.GetSuggestions();
            tcats.ShowRunTime();
            Console.WriteLine(tcats.ShowWhoView("Ava", "4"));

            Netflix houseOfCards = new Netflix();
            houseOfCards.Name = "House of Cards";
            houseOfCards.Genre = "Political Drama";
            houseOfCards.Rating = 3;

            tcats.ShowNumberOfMinutesLeft(7);

            Console.ReadLine();



        }
    }
}
