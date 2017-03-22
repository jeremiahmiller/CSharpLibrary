using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "1")
            {
                Console.WriteLine(":/");
            }

            if (feelingNumber == "2")
            {
                Console.WriteLine("Oh :/");
            }

            if (feelingNumber == "3")
            {
                Console.WriteLine("You OK?");
            }

            if (feelingNumber == "4")
            {
                Console.WriteLine("Cool!");
            }

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow");
            }
            else
            {
                Console.WriteLine("Sorry? Didn't hear you?");
            }
            Console.ReadLine();
        }
    }
}
