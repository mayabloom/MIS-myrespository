using System;
using System.Collections.Generic;

namespace Participation_Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Toy> toynames = new List<Toy>();

            string answer;
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
                toynames.Add(toy1);

                Console.WriteLine($"Your toy is on asile {toy1.GetAisle()}");

                Console.WriteLine("Would you like to add another toy?");
                answer = Console.ReadLine().ToLower();

                

               

            } while (answer[0] == 'y');
           
            Toy firsttoy = new Toy ("Hasbro" ,"Monopoly", 45.65, "This game is fun for the family!");
            toynames.Add(firsttoy);

            Toy secondtoy = new Toy ("Mattel" , "Barbie" ,23.56, "This doll is great as a gift!");
             toynames.Add(secondtoy);

            


        }
    }
}
