using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToyBox> toyboxes = new List<ToyBox>();
            List<Toy> toys = new List<Toy>();

            string input;
            string answer;
            do
            {
                Console.WriteLine("Who is the owner of your toybox?");
                string owner = Console.ReadLine();

                Console.WriteLine("What is the location of your toybox?");
                string location = Console.ReadLine();

                do
                {
                    Console.WriteLine("Who is the toy manufacturer?");
                    string manufacturer = Console.ReadLine();


                    Console.WriteLine("What is the name of your toy?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the price of your toy?");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the notes for your toy >>");
                    string notes = Console.ReadLine();

                    

                    Toy toy1 = new Toy(manufacturer, name, price, notes);
                    toys.Add(toy1);

                    Console.WriteLine("Would you like to add another toy?");
                    answer = Console.ReadLine().ToLower();

                    Console.WriteLine($"Your toy is on asile {toy1.GetAisle()}");

                } while (answer[0] == 'y');

                ToyBox toybox1 = new ToyBox();
                toybox1.Toys = toys;
                toybox1.Owner = owner;
                toybox1.Location = location;

                toyboxes.Add(toybox1);

                foreach (ToyBox toybox in toyboxes)
                {
                    foreach (Toy toy in toybox.Toys)
                    {
                        Console.WriteLine(toy.Name);
                    }
                    Console.WriteLine(toybox.Owner);
                   
                }

                Console.WriteLine("Would you like to add another toybox?");
                input = Console.ReadLine();

                

            } while (input[0] == 'y');

           

            Toy firsttoy = new Toy("Hasbro", "Monopoly", 45.65, "This game is fun for the family!");
            toys.Add(firsttoy);
            

            Toy secondtoy = new Toy("Mattel", "Barbie", 23.56, "This doll is great as a gift!");
            toys.Add(secondtoy);

            foreach (ToyBox toybox in toyboxes)
            {
                Console.WriteLine($"  Random Toy: {toybox.GetRandomToy().Name}");
            }
           







        }
    }
}
