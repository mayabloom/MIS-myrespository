using System;

namespace redo_hw_3__tutr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int firstnumber = rand.Next(1,51);
            int secondnumber = rand.Next(1, 51);
            int sum = firstnumber + secondnumber;
            int answer;

            do
            {
                Console.WriteLine($"{firstnumber} + {secondnumber} =? \nwhat is your guess? ");
                string guess = Console.ReadLine();

                if (int.TryParse(guess ,  out answer)==false)
                {
                    Console.WriteLine("Sorry that was an invalid input!");
                    Environment.Exit(-1);
                }
                if (sum != answer)
                {
                    Console.WriteLine("Sorry that was wrong try again!");
                }


            } while (sum != answer);

            Console.WriteLine("Congrats you guessed correctly!");

            

            
        }
    }
}
