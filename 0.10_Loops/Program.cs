using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //lcv - loop control variable
            //lcv = lcv + 1;
            //lcv += 1;
            //lcv++;
            for (int lcv = 0; lcv < 6; lcv += 1)
            {
                Console.WriteLine("paul is a joker");
            }
            /*
            Console.WriteLine("---------------");
            for (int i = 0; i < 10; i++)
            {
                //Can you use a conditional to print even numbers
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine(i);                }
            }
            Console.ReadLine();
        }   */

            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("-----------------");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
