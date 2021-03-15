using System;

namespace Collections_3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentIds = new string[3];
            double[] studentGPAs = { 3.0, 4.0, 2.5 };

            studentIds[0] = "1";
            studentIds[1] = "2";
            studentIds[2] = "3";

            //for (int i = 0; i < studentIds.Length; i++)
            //{
            //    string id = studentIds[i];
            //    Console.Write($"{id} ");
            //}

            

            foreach (string id in studentIds)
            {
                Console.Write($"{id} ");
            }

            Console.WriteLine("Whose GPA do you want to see?");
            string searchID = Console.ReadLine();

            for (int i = 0; i < studentIds.Length; i++)
            {
                string id = studentIds[i];
                double gpa = studentGPAs[i];

                if (id == searchID)
                {
                    Console.WriteLine($" {id} - {gpa.ToString("N3")}");
                }
                
            }
        }
    }
}
