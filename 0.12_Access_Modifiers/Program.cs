using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura pinto = new Acura("TL", 2000, 500);
            

            Console.WriteLine(pinto.CarDetails());

            Console.ReadLine();
        }
    }
}
