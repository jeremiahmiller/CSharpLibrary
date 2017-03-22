using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirsttName = "James";
            theJSWizard.LastName = "Handshoe";
            theJSWizard.PrintCustomerName();

            Customer theSheriff = new Customer();
            theJSWizard.FirsttName = "James";
            theJSWizard.LastName = "Handshoe";
            theSheriff.PrintCustomerName();

            Console.ReadLine();
        }
    }
}
