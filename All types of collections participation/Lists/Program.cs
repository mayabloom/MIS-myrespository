using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            double grade;
            string answer;

            while (true)
            {
                Console.WriteLine("Please enter the grades for your exam or no to continue >>");
                answer = Console.ReadLine();
                if (answer == "no")
                {
                    break;
                }

                grade = Convert.ToDouble(answer);
                examGrades.Add(grade);              
            }
            double totalpoints = 0;
            for (int i = 0; i < examGrades.Count; i++)
            {
                totalpoints = totalpoints + examGrades[i];
            }

            double average = totalpoints / examGrades.Count;
            Console.WriteLine($"The average for you exam grades is {average.ToString("N2")}");
        }
    }
}
