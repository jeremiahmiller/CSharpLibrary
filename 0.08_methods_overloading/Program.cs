using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.Name = "The JS Wisard";
            theJSWizard.Attack();
            theJSWizard.Attack("Dusty Sowrd");
            theJSWizard.Attack("Dusty Sword", 1);
            Console.ReadLine();
        }
    }
}
