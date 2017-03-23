using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Netflix
    {
        //FIELDS

        //PROPERTIES
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int TotalMinutes { get; set; }

        //METHODS
        /// <summary>
        /// Methods w/ no return
        /// </summary>
        public void GetSuggestions()
        {
            if (Rating > -4)
                Console.WriteLine("Good");
            else
                Console.WriteLine("Lame");

        }
        /// <summary>
        /// Methods that return a value
        /// </summary>
        /// <return><</return>
        public int ShowRunTime()
        {
            Console.WriteLine(this.Name + " is " + this.TotalMinutes);
                return this.TotalMinutes;
        }

        ///METHODS that have parameters
        public string ShowWhoView(string username, string time)
        {
            string details = username + " Watched this at " + time;
            return details;
        }

        //Takes in a Parameter of num minutes watched.
        //Returns number of minutes left.
        public int ShowNumberOfMinutesLeft(int minutesViewed)
        {
            int numMinutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("There are " + numMinutesLeft + " minutes left in " + this.Name);
            return numMinutesLeft;
        }




    }
}
