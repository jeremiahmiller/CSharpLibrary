using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Customer
    {
        //FEILDS

        //PROPERTIES
        public int CustomerID { get; set; }
        public string FirsttName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool AppearsWealthy { get; set; }
        public decimal BankRoll { get; set; }
        
        //METHODS
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirsttName, LastName);
        }
    }
}
