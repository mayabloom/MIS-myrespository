using System;

namespace Redo_student_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            double studentid;

            Console.WriteLine("What is your student id?");
            string id = Console.ReadLine();
            studentid = Convert.ToDouble(id);

            double homeworkgrade;

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            string hwgrade = Console.ReadLine();
            homeworkgrade = Convert.ToDouble(hwgrade);

            double participationgrade;

            Console.WriteLine("What is your overall percentage grade for participations?");
            string participation = Console.ReadLine();
            participationgrade = Convert.ToDouble(participation);

            double quizgrade;

            Console.WriteLine("What is your overall percentage grade for quizzes? ");
            string quiz = Console.ReadLine();
            quizgrade = Convert.ToDouble(quiz);

            double midtermgrade;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            string midterm = Console.ReadLine();
            midtermgrade = Convert.ToDouble(midterm);

            double fgrade;

            Console.WriteLine("What is your overall percentage grade for the final?");
            string final = Console.ReadLine();
            fgrade = Convert.ToDouble(final);

            double finalsgrade = (homeworkgrade * .08) + (participationgrade * .12) + (midtermgrade * .40) + (fgrade * .40);
            Console.WriteLine($"{firstname} {lastname} ({studentid}) , your final grade for the course is {finalsgrade.ToString("N0")} %");

        }
    }
}
