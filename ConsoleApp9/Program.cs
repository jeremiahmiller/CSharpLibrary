using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Kenn";

            switch (friend)
            {
                case "Fred";
                    Console.WriteLine("Hey Fred");
                    break;
                case "Kenn";
                    Console.WriteLine("Hey Kenn");
                    break;
                default:
                    Console.WriteLine("You hit the default.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
