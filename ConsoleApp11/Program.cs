using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts appleCinn = new Donuts();
            appleCinn.filling = "apple pie";
            appleCinn.isSpecial = false;
            appleCinn.price = 0.99M;
            appleCinn.type = "Filling";

            Console.WriteLine(appleCinn.filling);

            Donuts longJohn = new Donuts();
            longJohn.filling = "Bavarian Creme";
            longJohn.isSpecial = true;
            longJohn.price = 1.25M;
            longJohn.type = "Filled";

            Console.WriteLine("A longjohn costs abut {0:C}", longJohn.
            Console.ReadLine();

        }
    }
}
