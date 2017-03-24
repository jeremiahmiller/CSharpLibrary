using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;
            barryTheBear.Walks();
            barryTheBear.Speak();

            dog Spot = new dog();
            Spot.Weight = 250;
            Spot.HasEyes = true;

            Polor_Bear cokeACola = new Polor_Bear();
            Animal theJSWiz = new Animal();
            theJSWiz.NumberOfLegs = 2;
            Console.ReadLine();
            {

            }
        }
    }
}
