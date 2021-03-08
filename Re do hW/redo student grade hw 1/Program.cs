using System;

namespace redo_student_grade_hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();


            double studentID;

            Console.WriteLine("What is your student id?");
            string response = Console.ReadLine();
            studentID = Convert.ToDouble(response);

            double hwgrade;

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            string homework = Console.ReadLine();
            hwgrade = Convert.ToDouble(homework);

            double participationgrade;

            Console.WriteLine("What is your overall percentage grade for participations?");
            string participation = Console.ReadLine();
            participationgrade = Convert.ToDouble(participation);

            double quizgrade;

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            string quizzes = Console.ReadLine();
            quizgrade = Convert.ToDouble(quizzes);

            double midtermgrade;

            Console.WriteLine("What is your overall percentage grade for the midterm? ");
            string midterm = Console.ReadLine();
            midtermgrade = Convert.ToDouble(midterm);

            double final;

            Console.WriteLine("What is your overall percentage grade for the final");
            string finals = Console.ReadLine();
            final = Convert.ToDouble(finals);


            double finalgrade = ((hwgrade * .08) + (participationgrade * .12) + (midtermgrade * .40) + (final * .40));

            Console.WriteLine( $"{firstname}  {lastname} {studentID}, your final grade is {finalgrade}  % ");




        }
    }
}
