using System;

namespace redo_hw_3_tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int lefthandoperand = rand.Next(1, 51);
            int righthandoperand = rand.Next(1, 51);
            int sum = lefthandoperand + righthandoperand;
            int answer;

            do
            {
                Console.WriteLine($"{lefthandoperand.ToString("N0")} + {righthandoperand.ToString("N0")} = ? \nwhat is your answer? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out answer) == false)
                {
                    Console.WriteLine($"Sorry {input} was an invalid answer. Goodbye!");
                    Environment.Exit(-1);

                }

                if (sum != answer)
                {
                    Console.WriteLine("Sorry that was wrong. Please try again!");
                }


            } while (sum!= answer); 
                Console.WriteLine("Congrats that was correct!");
            

        }
    }
}
