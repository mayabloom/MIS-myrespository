using System;

namespace Participation_Feb_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(10,21);
            Console.WriteLine(" {randomNbr}");

        }
    }
}
