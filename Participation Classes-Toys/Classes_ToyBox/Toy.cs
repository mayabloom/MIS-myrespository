using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
     public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = " "; //Manufacturer=string.empty;
            Name = " ";
            Price = 0;
            Notes = " ";





        }

        public Toy(string manufacturer, string name, double price, string notes)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {

            Random rand = new Random();
            int randomnumber = rand.Next(1, 25);

            return ($" {Manufacturer[0]}{randomnumber} ");
        }
    }
}
