using System;

namespace redo_hw_2_trivia_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0;

            Console.WriteLine(" The sky is blue");
            string answer = Console.ReadLine();

            if (answer.ToUpper() =="T")
            {
                score = score + 1;
            }
            else if (answer.ToUpper() =="F")
            {
                score = score + 0;
            }

            else
            {
                Console.WriteLine("Sorry answer was invalid! Goodbye!");
                Environment.Exit(-1);
            }

            Console.WriteLine("The apple is green");
            answer = Console.ReadLine();

            if (answer.ToUpper()=="T")
            {
                score = score + 1;
            }

            else if (answer.ToUpper()=="F")
            {
                score = score + 0;

            }
            else
            {
                Console.WriteLine("Sorry answer was invalid.GoodBye!");
                Environment.Exit(-1);
            }

            double percentage = score / 2;

            Console.WriteLine($"Congrats you got a {percentage.ToString("P2")} % ");
        }

    }
}
