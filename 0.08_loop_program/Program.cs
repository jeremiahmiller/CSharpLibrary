using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_loop_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Enter Starting Number: ");
            int StartingNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hey! Enter Ending Number: ");
            int EndingNumber = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = StartingNumber; i <= EndingNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of all numbers between {0} and {1} is {2}", StartingNumber, EndingNumber, sum);
            Console.ReadLine();
        }
    }
}
