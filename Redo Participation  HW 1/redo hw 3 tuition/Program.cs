using System;

namespace redo_hw_3_tuition
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TUITION_INCREASE_PER_SEMESTER = .05;

            double tuition = 12000;

            for (int i = 1; i <= 7; i++)
            {
                tuition = tuition * (1 + TUITION_INCREASE_PER_SEMESTER);
                Console.WriteLine($"After year {i} tuition will be {tuition.ToString("c2")}");
            }

           
        }

    }
}
