using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Strucks
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder p1",
                City = "New Zeland",
                State = "Arizona",
                Zip = "12345",
                FirstName = "Paul",
                LastName = "Zoolander",
                Age = "18"
            };
            Console.WriteLine(Paul.GetAddress());
            Console.ReadLine();
        }
        struct addressbook
        {
            public string FirstName;
            public string LastName;
            public string Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;



            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }
        }
    }   
}
