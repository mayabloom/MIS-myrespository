using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            List<double> MISgrades = new List<double>();

            MISgrades.Add(.96);
            MISgrades.Add(.95);
            MISgrades.Add(.93);

            List<double> ACCTgrades = new List<double>();
            ACCTgrades.Add(.92);
            ACCTgrades.Add(.85);
            ACCTgrades.Add(.88);

            List<double> FINgrades = new List<double>();
            FINgrades.Add(.99);
            FINgrades.Add(.97);
            FINgrades.Add(.96);

            students.Add("MIS3213", MISgrades);
            students.Add("ACCT3353", ACCTgrades);
            students.Add("FIN3013", FINgrades);

            List<double> gradesinputed = new List<double>();

            Console.WriteLine("Do you want to add another course and grade? >>");
            string answer = Console.ReadLine();

            do
            {

                if (answer.ToLower()[0] == 'y')
                {
                    Console.WriteLine("What is the course code? >> ");
                    string courseCode = Console.ReadLine();

                    Console.WriteLine($"What is the grade for {courseCode}? >>");
                    double grade = Convert.ToDouble(Console.ReadLine());
                    gradesinputed.Add(grade);



                    while (true)
                    {
                        Console.WriteLine("Do you want to add another grade? >>");
                        answer = Console.ReadLine();

                        Console.WriteLine("What is the grade for the class? (ex: .95, .86)");
                        grade = Convert.ToDouble(Console.ReadLine());
                        gradesinputed.Add(grade);

                        if (students.ContainsKey(courseCode) == false)
                        {
                            students.Add(courseCode, gradesinputed);
                            break;
                        }
                        else
                        {

                            Console.WriteLine("Already contains that key");
                        }

                    }
                }

                Console.WriteLine("Do you want to add another course and grade? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');


            double listedgrades = 0;


            foreach (string courses in students.Keys)
            {
                double totalpoints = 0;
                for (int i = 0; i < students[courses].Count; i++)
                {
                    totalpoints = students[courses][i] + totalpoints;
                    listedgrades = students[courses].Count;
                }



                double average = totalpoints / listedgrades;
                Console.WriteLine($"The average of your {courses} scores is {average.ToString("P2")}");
            }



            //for (int i = 0; i < students.Count; i++)
            //{
            //    totalpoints = totalpoints + gradesinputed[i];
            //}




        }
    }
}





