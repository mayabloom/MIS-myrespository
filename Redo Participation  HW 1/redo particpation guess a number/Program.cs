using System;

namespace redo_particpation_guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" Guess a minimum value >>");
            //string minimum = Console.ReadLine();
            //int minimumnumber = Convert.ToInt32(minimum);



            // Console.WriteLine("Guess a maximum value >>");
            // string max = Console.ReadLine();
            // int maxnumber = Convert.ToInt32(max);

            // Random rand = new Random();
            // int rndNbr = rand.Next(minimumnumber, maxnumber);



            // Console.WriteLine($" Guess a number between {minimumnumber} and {maxnumber}");
            // string ans = Console.ReadLine();
            //double guess = Convert.ToDouble(ans);

            // if (double.TryParse(ans, out guess)==false)
            // {
            //     Console.WriteLine("Sorry INPUT WAS INVALID!");
            //     Environment.Exit(-1);
            // }

            // while (guess ! ==  rndNbr)
            // {
            //     Console.WriteLine($" Guess a number between {minimumnumber} and {maxnumber}");
            //     ans = Console.ReadLine();
            //     guess = Convert.ToDouble(ans);

            // }

            Console.WriteLine("Pick a minimum value");
            string min = Console.ReadLine();
            int minimumnumber = Convert.ToInt32(min);

            Console.WriteLine("Pick a maximum value");
            string max = Console.ReadLine();
            int maxnumber = Convert.ToInt32(max);
            int guess;

            Random rand = new Random();
            int rndMbr = rand.Next(minimumnumber, maxnumber);


            do
            {
                Console.WriteLine($"Guess a number between {minimumnumber} and {maxnumber}");
                string answer = Console.ReadLine();

                if (int.TryParse(answer, out guess)==false)
                {
                    Console.WriteLine("Sorry input was invalid!");
                }

                if (rndMbr != guess)
                {
                    Console.WriteLine("Sorry that was wrong. Guess again!");
                }

            } while (rndMbr != guess);
            Console.WriteLine("Congrats you guessed correctly");

        }
    }
}
