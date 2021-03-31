using System;
using System.Collections.Generic;

namespace In_class_example___methods_3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            List <double> gpas = new List<double>();
            string answer;

            do
            {
                double gpa = ValidateDoubleInput("Please enter a GPA>>");
                gpas.Add(gpa);



                //bool shouldContinue = AskUserToContinue();
                Console.WriteLine("Do you want to enter more numbers?");
                answer = Console.ReadLine();
                

            } while (AskUserToContinue() == true);

          
            List<double> itemprices = new List<double>();

            bool shouldContinue;
            do
            {
                shouldContinue = AskUserToContinue();
                double ItemPrice = ValidateDoubleInput("Please enter the item price>>");
                itemprices.Add(ItemPrice);

                Console.WriteLine("Do you want to enter more item prices?");
                answer = Console.ReadLine();

            } while (shouldContinue == true);

        }

        private static bool AskUserToContinue()
        {
            Console.WriteLine("Do you want to go again? Yes or No >>");
            string answer = Console.ReadLine().ToLower();

            while (answer != "yes" & answer != "no")
            {
                Console.WriteLine("Sorry you must answer yes or no");

                Console.WriteLine("Do you want to go again? Yes or No >>");
                 answer = Console.ReadLine().ToLower();
            }
            if (answer == "yes")
            {
                return true; 
            }
            return false;

        }

        static double ValidateDoubleInput(string message)
        {
            double value;
            string answer;

            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();

                //bool isDouble = double.TryParse(answer, out value);

            } while (double.TryParse(answer, out value)== false);

            return value;
        }
    }
}
