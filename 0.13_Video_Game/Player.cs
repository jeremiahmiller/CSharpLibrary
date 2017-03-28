using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Video_Game
{   
    public enum CharacterType
    {
        Assassin = 0,
        SillyPuff = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Player
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        //Constructor
        public Player(string name, string clanName, CharacterType type = CharacterType.Human)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
        }
        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You're a SillyPuff!");
                    return this.Type = CharacterType.SillyPuff;
                case 2:
                    Console.WriteLine("You're a Professor!");
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You're a HorseMange!");
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    Console.WriteLine("You're a TaxMan!");
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    Console.WriteLine("You're a Human!");
                    return this.Type = CharacterType.Human;
                default:
                    Console.WriteLine("You're a Human!");
                    return this.Type = CharacterType.Human;

                
            }
        }

        //make a method that you can call on a player object that prints out the player's power
        public void PowerLevel()
        {
            Console.WriteLine("{0}'s power level is at {0}", this.PlayerName, this.CurrentPower);
        }
        //make a method for your player object for your battle cry
        public void BattleCry()
        {
            Console.WriteLine("Ahhhhhhhhhhhhhhhhh!");
        }

        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.PlayerName}";
        }


    }
}
