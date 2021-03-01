using System;

namespace Conditional_coin_toss_example_with_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_NAME;
            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine({ randomNbr});

            const int HEADS = 1;
            const int TAILS = 2;

            Console.WriteLine("Heads of Tails>>>");
            string answer = Console.ReadLine();

            int answerasInt;

            if (answer.ToLower() == "heads") 
            {
                answerasInt = HEADS;
            }
            else
            {
                answerasInt = TAILS;
            }

            if (answerasInt == randomNbr) 
            {

                Console.WriteLine($"Wow good guess!");

            }

            else
            {
                Console.WriteLine($"Better luck next time!");
            }

            Console.WriteLine("\n\n" + "Created by :" + DEVELOPER_Name);
        }
    }
}
