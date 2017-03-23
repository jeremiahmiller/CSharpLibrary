using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_methods_overloading
{
    class Player
    {
        //PROPERTIES
        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine("The player attacked for 5 points");

        }
        public void Attack(string weapon)
        {
            Console.WriteLine("The player attacked with the sword " + weapon);

        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine(this.Name + "The player attacked with the sword " + weapon + "for " + attackPoints);
        }
    }
}
