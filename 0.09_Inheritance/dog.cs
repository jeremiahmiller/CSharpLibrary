using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Inheritance
{
    class dog : Animal
    {
        public bool HasTail { get; set; }
        public bool IsAGoodBoy { get; set; }
        public bool IsFriendly { get; set; }

        public void Speak()
        {
            Console.WriteLine("Bark");
        }
        public void Walk()
        {
            Console.WriteLine("Fast");
        }
        
        

    }
}
