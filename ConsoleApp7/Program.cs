using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;

            Console.WriteLine("I have {0} in my bank acount, and I am {1} in debt", bankAccount, debt);
            if (difference >= 7000 && difference <= 1999)
            {
                Console.WriteLine("I have extra money to buy socks this month");
            }
            else if ((bankAccount -debt > 2000))
            {
                Console.WriteLine("I have a bunch of extra money");
            }
            else
            {
                Console.WriteLine("It isn't a good time to pay off debt");
            }
            Console.ReadLine();
    }
}
