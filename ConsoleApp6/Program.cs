using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNumber = 13;

            if (elevatorUp == true)
            {
                //DO stuff
                Console.WriteLine("Going up");
            }
            else
            {
                //Do something else
                Console.WriteLine("Going down");
            }
            if (elevatorBroken)
            {
                Console.WriteLine("Panic!!!");
            }
            else
            {
                Console.WriteLine("Have a Good Day");
            }
            if (elevatorStuckWhileWeAreInIt && elevatorDown)
            {
                Console.WriteLine("Let's get rescued");
                Console.WriteLine("Yeah");
            }
            else
            {
                Console.WriteLine("Yea!");
            }
            if (elevatorNumber == 13)
            {
                Console.WriteLine("I'm scared we are going to suffocat");
            }
            Console.ReadLine();
        }
    }
}
