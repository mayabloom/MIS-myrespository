using System;

namespace redo_participation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_NAME = "Maya Bloom";

            Random rand = new Random();
            int toss = rand.Next(0, 2);
            Console.WriteLine($"{toss}");

            Console.WriteLine("Please pick heads or tails ");
            string answer = Console.ReadLine().ToUpper();

            
            
            
            string coin;

            if ( toss == 0)
            {
                coin = "HEADS";
            }
            else
            {
                coin = "Tails";
            }

            if (answer.ToLower()==coin)
            {
                Console.WriteLine("Congrats you guessed correctly!");
            }
            else
            {
                Console.WriteLine("Sorry better luck next time");

            }
            Console.WriteLine($" {DEVELOPER_NAME}");
            

        }
    }
}
