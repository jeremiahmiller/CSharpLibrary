using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if (num == 7)
                Console.WriteLine("Hey this is the number 7");
            else
                Console.WriteLine("This number isn't 7");

            Console.WriteLine(num == 7 ? "Hey this is the number 7" : "This number isn't 7");
            Console.ReadLine();
        }
    }
}
