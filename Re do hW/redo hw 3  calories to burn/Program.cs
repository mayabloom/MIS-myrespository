using System;

namespace redo_hw_3__calories_to_burn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CALORIES_BURNED_PER_MINUTES = 3.9;

            Console.WriteLine("How many calories would you like to burn this workout session");
            string answer = Console.ReadLine();
            double goal;

            if (double.TryParse(answer, out goal)==false)
            {
                Console.WriteLine($"Sorry {answer} was an invalid response. Goodbye!");
                Environment.Exit(-1);
            }

            double caloriesburnedsofar = 0;
            int minutes = 0;

            if (goal == 0)
            {
                Console.WriteLine("Come on you can do better!");
            }

            else
            {
                while (caloriesburnedsofar < goal)
                {
                    minutes++;
                    caloriesburnedsofar = CALORIES_BURNED_PER_MINUTES + caloriesburnedsofar;
                    Console.WriteLine($"After {minutes} you have burned {caloriesburnedsofar.ToString("g2")} calories");
                }
            }
        }
    }
}
