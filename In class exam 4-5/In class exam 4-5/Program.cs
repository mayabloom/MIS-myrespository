using System;

namespace In_class_exam_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input your grade in the course >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                string lg = ConvertGradetoLetterGrade(grade); // method will never get ran without this line if we don't call this method
                Console.WriteLine($"Congratulations you have an {lg} in the course");

                Console.WriteLine("Do you want to convert another grade? Yes or No >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
        }

        /// <summary>
        /// Convert a standard grade (e.g. 98.5) to the appropraite letter grade (e.g. A)
        /// </summary>
        /// <param name="anyVariableNameWeWantThisBelongsToThisMethod"> The grade to convert to a letter grade (e.g. 98)</param>
        /// <returns> Returns a string that is the letter grade of the input. N/A if it is below 0</returns>
        static string ConvertGradetoLetterGrade(double anyVariableNameWeWantThisBelongsToThisMethod)// method that accepts parameter type double
        {
            string letterGrade;
            if (anyVariableNameWeWantThisBelongsToThisMethod >=90)
            {
                letterGrade = "A";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >=80)
            {
                letterGrade = "B";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >=70)
            {
                letterGrade = "C";
            }

            else if (anyVariableNameWeWantThisBelongsToThisMethod >=60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "N/A";
            }

            return letterGrade;
        }
    }
}
