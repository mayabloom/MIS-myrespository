using System;
using System.Collections.Generic;
using System.Text;

namespace Participation_Classes_Toys
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
            Notes = string.Empty;
            
            



        }

        public void AddNote(string note)
        {
            Notes += "\n" + note;
        }

        public Toy( string manufacturer, string name, double price, string notes)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = notes;
        }
        public string GetNotes()
        {
            return Notes;
        }

        public string GetAisle()
        {
            
            Random rand = new Random();
            int randomnumber = rand.Next(1, 25);

            return ($" {Manufacturer[0]}{randomnumber} ");
        }

       

    }
}
