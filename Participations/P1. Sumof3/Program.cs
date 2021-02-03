using System;

namespace P1._Sumof3
{
    class Program
    {
         static double ClassLevelVariable = 5;
        static void Main(string[] args)
        {

            const double MAGIC_NUMBER = 7.777; // local variable that is a constant

            double heresMyDouble;
            double heresMyDoubletwo;
            double heresMyDoublethree;

            Console.WriteLine($"Please enter a number >>");
            string answer = Console.ReadLine();
            heresMyDouble = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter another number >>");
            answer = Console.ReadLine();
            heresMyDoubletwo = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter a last number >>");
            answer = Console.ReadLine();
            heresMyDoublethree = Convert.ToDouble(answer);

            double result = heresMyDouble + heresMyDoubletwo + heresMyDoublethree;

            Console.WriteLine(" The sum of the numbers is " + result.ToString("N3"));

            double multiplied = result * MAGIC_NUMBER;
            Console.WriteLine(result.ToString("N3") + " times 7.777 = " + multiplied);


        }   
    }
}  
