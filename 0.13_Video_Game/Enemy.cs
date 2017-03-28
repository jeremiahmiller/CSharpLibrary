using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Video_Game
{
    class Enemy
    {
        protected ArrayList insult = new ArrayList { "buck-o", "buster", "buck-aru" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //creat an insult method
        public virtual void Insult()
        {
            int r = rnd.Next(insult.Count);

            Console.WriteLine("Rar", insult[r]);
        }
        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {

            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1}", attackName, attackVal);



            Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal;
        }
    }
}

