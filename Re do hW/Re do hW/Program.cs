using System;

namespace Re_do_hW
{
    class Program
    {
        const double SALES_TAX = .085;
        static void Main(string[] args)
        {
            string productname;
            double tickets;
            double ticketprice;

            Console.WriteLine("What is the name of the item you are purchasing? ");
            string response = Console.ReadLine();
            productname = Convert.ToString(response);

            Console.WriteLine($"How many {productname} ticket's do you want to buy?");
            string answer = Console.ReadLine(); 
            tickets = Convert.ToDouble(answer);

            Console.WriteLine($"What is the price for each {productname} Ticket?");
            string price = Console.ReadLine();
            ticketprice = Convert.ToDouble(price);

            double subtotal = tickets * ticketprice;
            double salestax = subtotal * SALES_TAX;
            double total = subtotal + salestax;


            Console.WriteLine($"Your subtotal for your bill is {subtotal.ToString("C2")} ");
            Console.WriteLine($"Your sales tax for your bill is {salestax.ToString("C2")} ");
            Console.WriteLine($"Your total for your bill is {total.ToString("C2")} ");



        }
    }
}
