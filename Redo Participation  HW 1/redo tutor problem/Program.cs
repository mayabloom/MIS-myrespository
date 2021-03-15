using System;

namespace redo_tutor_problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int firstnumber = rand.Next(1, 51);
            int secondnumber = rand.Next(1, 51);
            int sum = firstnumber + secondnumber;
            int number;

            do
            {
                Console.WriteLine($"{firstnumber} + {secondnumber} =? \nwhat is your answer?");
                string answer = Console.ReadLine();


                if (int.TryParse(answer, out number) == false)
                {
                    Console.WriteLine("Input was invalid try again!");
                }

                if (sum != number)
                {
                    Console.WriteLine("Sorry that was wrong try again!");
                }




            } while (sum != number);
            Console.WriteLine("Congrats you added correctly");
        }
    }
}
