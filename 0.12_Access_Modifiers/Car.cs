using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Access_Modifiers
{
    class Car
    {
        protected String Make { get; set; }
        protected String Model { get; set; }
        protected int Year { get; set; }

        protected string CarDetails()
        {
            return $"Make: {Make} Model: {Model} Year: {Year}";
        }

    }
    class Acura : Car
    {
        private int price;

        public Acura(string model, int year, int price)
        {
            this.Make = "Acura";
            this.Model = model;
            this.Year = year;
            this.price = price;
        }

        protected string CarDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }
    }
}
