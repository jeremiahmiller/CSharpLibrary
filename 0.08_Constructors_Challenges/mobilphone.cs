using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Constructors_Challenges
{
    class mobilphone
    {   
        //CONSTRUCT
        public mobilphone(string make, string model)
        {
            Make = Make;
            Phone = Phone;
        }

        //PROPERTIES
        public int Make { get; set; }
        public int Phone { get; set; }

        //METHODS
        public void Print()
        {
            Console.WriteLine("I own an " + Make + " " + Phone);
        }
    }
}
