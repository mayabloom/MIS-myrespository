using System;

namespace redo_hw_tuition
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TUTION_INCREASE = .05;

            double tuition = 12000;
            for (int i = 1; i < 7; i++)
            {
                tuition = tuition * (1 + TUTION_INCREASE);
                Console.WriteLine($" The tuition after year {i} will be {tuition.ToString("C2")} ");
            }

           
        }
    }
}
