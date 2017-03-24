using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student devon = new Student();
            devon.FirstName = "Devon";
            devon.LastName = "Peetz";
            devon.Age = 25;

            Student shelby = new Student("Shelby");

            Student charlesMichael = new Student("Charles", "Michael", 30, "Assassin");
            Student jeremiah = new Student("Jeremiah", "Miller", 18, "Padawan");
            Console.ReadLine();
        }
    }
}
