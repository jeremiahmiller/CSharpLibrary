using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Video_Game
{
    class SubEnemy : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
        {
            { "Head-butt", 5 },
            { "Mallet", 15 }
        };

        //Constructor
        public SubEnemy()
        {
            this.PowerLevel = 40;
            this.Name = "SubEnemy";
        }
        //Method
        public override void Insult()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }

        public void SubEnemyAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }
    }
}
