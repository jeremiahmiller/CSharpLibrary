using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            bool isAdmin = true;
            bool isLoggedIn = true;
            
            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site Admin");
            }

            if (isLoggedIn)
            {
                Console.WriteLine("You're logged in as an administrator");
            }

            if (isOn)
            {
                Console.WriteLine("The light is on.");
            }

            Console.ReadLine();
        }
    }
}
