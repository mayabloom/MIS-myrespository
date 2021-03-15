using System;

namespace red_calories_burned
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CALORIES_BURNED_PER_MINUTE = 3.9;

            Console.WriteLine("How many calories would you like to burn this session?");
            string answer = Console.ReadLine();
            double goal;

            if (double.TryParse(answer, out goal)==false)
            {
                Console.WriteLine("Sorry input was invalid ");
            }

            if (goal == 0 )
            {
                Console.WriteLine("Come on many you can do better!");
            }


            double minutes = 0;
            double caloriesburnedsofar = 0;

            while (caloriesburnedsofar <goal)
            {
                minutes++;
                caloriesburnedsofar = caloriesburnedsofar + CALORIES_BURNED_PER_MINUTE;
                Console.WriteLine($"After {minutes} you have burned {caloriesburnedsofar} calories");
            }
        }
    }
}
