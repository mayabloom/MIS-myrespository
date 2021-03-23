using System;

namespace All_types_of_collections_participation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courseCodes = new string[3];
            double[] courseNumbers = new double[3];

            string answer;
            double input;
            string course;
            

           

            for (int i = 0; i < courseCodes.Length; i++)
            {
                Console.WriteLine("Please enter a course codes >>");
                answer = Console.ReadLine();
                courseCodes[i] = answer;
            }

            
            for (int i = 0; i < courseNumbers.Length; i++)
            {
                Console.WriteLine("Please enter a courseNumbers>>");
                course = Console.ReadLine();
                input = Convert.ToDouble(course);
                courseNumbers[i] = input;
            }


            
            for (int i = 0; i < courseCodes.Length; i++)
            {
                  string subjects = string.Concat(courseCodes[i], courseNumbers[i]);
                Console.WriteLine(subjects);
            }
            














        }

            

        }
    }



    

    //Console.WriteLine("Do you have another exam grade to enter?");
    //answer = Console.ReadLine();

