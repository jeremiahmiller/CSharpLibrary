using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Video_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan are you a part of?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" + "0: Assassin\n" + "1: SillyPuff\n" + "2: Professor\n" + "3: HorseMange\n" + "4: TaxMan\n" + "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(0);

            Console.WriteLine(player.ToString());

            SubEnemy subEnemy = new SubEnemy();

            while (true)
            {
                Console.WriteLine("You wanna fight?\n" + "Y or N?");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    subEnemy.SubEnemyAttack(player);
                    if (player.CurrentPower <= 0)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            subEnemy.Insult();

            Console.ReadLine();
        }
    }
}
