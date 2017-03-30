using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Link
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {VIN = "12345678", Make = "Ford", Model = "Truck", Year = "1028", Price = "$1,000"},
                new UsedCar() {VIN = "12345678", Make = "Chevy", Model = "Truck", Year = "2018", Price = "$1,000"},
                new UsedCar() {VIN = "12345678", Make = "Toyota", Model = "Prius", Year = "2018", Price = "$1,000"},
                new UsedCar() {VIN = "12345678", Make = "BMW", Model = "X5", Year = "2018", Price = "$1,000"}
            };

            var BMWs = from car in usedCars
                       where car.Make == "BMW"
                       select car;

            foreach (var BMW in BMWs)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", BMW.Year, BMW.Model, BMW.Price);
            }
            Console.WriteLine("");
            Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in toyotas)
            {
                Console.WriteLine("toyota.Model");
            }
            Console.ReadLine();
        }
    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
    }
}
