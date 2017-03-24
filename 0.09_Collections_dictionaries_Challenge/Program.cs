using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_dictionaries_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Russell", "2000");
            dictionary.Add("Denzel", "2001");
            dictionary.Add("Ardien", "2002");
            dictionary.Add("Sean", "2003");

            foreach (KeyValuePair<string, string> definition in dictionary)
            {
                Console.WriteLine("{0}: {1}", defnition.Key, definition.Value);
            }
            Console.ReadLine();
            

            //An array in a dictionary
            
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
            dictionary.Add("2000", new string[] { "Gladiator", "Chocolate", "Chrouching Tiger, Hidde Dragon" });
            dictionary.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" });
            dictionary.Add("2002", new string[] { "Chicogo", "Gangs of New York", "Harry Potter" });

            foreach (KeyValuePair<string, string[]> definition in dictionary)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", definition.Key, definition.Value[0], definition.Value[1], definition.Value[2], definition.Value[3]);
            }
            
            Console.ReadLine();
            

            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if (dictionary.ContainsKey(input1))
            {
                string valueForKey = dictionary[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type the year to show the movies");
            string input2 = Console.ReadLine();

            if (dictionary.ContainsKey(input2))
            {
                string[] valurForKey = dictionary[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString);
            }
            /*
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
            dictionary.Add("2000", new string[] { "Gladiator", "Chocolate", "Chrouching Tiger, Hidde Dragon" });
            dictionary.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" });
            dictionary.Add("2002", new string[] { "Chicogo", "Gangs of New York", "Harry Potter" });

            foreach (KeyValuePair<string, string[]> definition in dictionary)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", definition.Key, definition.Value[0], definition.Value[1], definition.Value[2], definition.Value[3]);
            }
            */
            Console.ReadLine();

        }
    }
}
