using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
     public class ToyBox
    {
        
        
            public List<Toy> Toys { get; set; }

            public string Owner { get; set; }

            public string Location { get; set; }

            public ToyBox()
            {
                Toys = new List<Toy>();
                Owner = string.Empty;
                Location = string.Empty;
            

            }
        //public ToyBox( List<Toy> toys, string owner, string location)
        //{
        //    Toys = toys;
        //    String Owner = owner;
        //    String Location = location;
        //}
        public  Toy GetRandomToy()
        {
           
            Random rand = new Random();
            int index = rand.Next(0, Toys.Count);

            return Toys[index];
            
            
        }

        }
    }
