using System;

namespace redo_hw_trivia_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0;

            Console.WriteLine(" Sprite is the best. T/F");
            string answer = Console.ReadLine();

            if (answer.ToUpper()=="T")
            {
                score = score + 1;

            }
            else
            {
                score = score + 0;
            }

            Console.WriteLine("My shirt is blue. T/F");
            answer = Console.ReadLine();

            if (answer.ToUpper()=="T")
            {
                score = score + 1;
            }

             double percent = score/2
                ;

            Console.WriteLine($"Congrtas you got {score.ToString("N0")} /2 correct!. You got {percent.ToString("P0")} correct");


        }
    }
}
