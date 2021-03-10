using System;

namespace Redo_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SALES_TAX = .085;

            Console.WriteLine("What is the name of the item you are purchasing?");
            string productname = Console.ReadLine();

            double Tickets;

            Console.WriteLine($"How many {productname} ticket's do you want to buy?");
            string ticketnumber = Console.ReadLine();
            Tickets = Convert.ToDouble(ticketnumber);

            double ticketprice;

            Console.WriteLine($"What is the price for each {productname} Ticket?");
            string price = Console.ReadLine();
            ticketprice = Convert.ToDouble(price);

            double subtotal = Tickets * ticketprice;
            double salestax = subtotal * SALES_TAX;
            double total = subtotal + salestax;

            Console.WriteLine($"Your subtotal for your bill is {subtotal.ToString("C2")}");
            Console.WriteLine($"Your sales tax for your bill is {salestax.ToString("C2")}");
            Console.WriteLine($"Your total for your bill is {total.ToString("C2")}");



        }
    }
}
