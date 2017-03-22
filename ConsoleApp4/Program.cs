using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Jeremiah";
            lastName = "Miller";
            occupation = "Programmer";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //String Interpolation
            Console.WriteLine("Name: {0}\nOccupation: {1}\n{2}", fullName, occupation, "Jeremiah");
            Console.WriteLine("{0:C}", 100.36);
            Console.WriteLine("{0:N}", 36);
            Console.WriteLine("{0:X}", 0);

            Console.ReadLine();
        }
    }
}
