using System;

namespace participation_methods
{
    class Program


    {
        static void Main(string[] args)
        {

            string userinformation = DeveloperInformation("Maya Bloom", "MIS3013", "4/6/2021");
            Console.WriteLine(userinformation);




            double sum = Add(3, 4); //argument
            double sub = Subtract(7, 4);
            double mul = Multiply(3, 5);
            double div = Divide(10, 5);

            string answer;
            string input;


            do
            {
                Console.WriteLine(" What calculation would you like to perform? (e.g. addition, subtraction, multiplication, division >>)");
                answer = Console.ReadLine().ToLower();
               

                if (answer == "addition")
                {
                    Console.WriteLine(sum);
                }
                else if (answer == "subtraction")
                {
                    Console.WriteLine(sub);
                }

                else if (answer == "multiplication")
                {
                    Console.WriteLine(mul);
                }
                else
                {
                    Console.WriteLine(div);
                }

                Console.WriteLine("Do you want to do another calculation? Yes or No >>");
                input = Console.ReadLine();

                if (input.ToLower()[0] == 'n')
                {
                    Console.WriteLine(" Thank you for using this service");
                }


            } while (input.ToLower()[0] == 'y');

            



        }


        /// <summary>
        /// Sums up two values 
        /// </summary>
        /// <param name="val1"> The left hand operand of the equation </param>
        /// <param name="val2"> The right hand operand of the equation</param>
        /// <returns> the sum of the two numbers </returns>
        static double Add(double val1, double val2) //parameters are val1 and val2 
        {
            double number = val1 + val2;
            return number;


            //return val1 + val2;
        }

        static double Subtract(double val1, double val2)
        {
            double number = val1 - val2;
            return number;
        }

        static double Multiply(double val1, double val2)
        {
            double number = val1 * val2;
            return number;

        }

        static double Divide(double val1, double val2)
        {
            double number = val1 / val2;
            return number;
        }

        static string DeveloperInformation(string userinfo, string classname, string date)
        {
            return userinfo + " " + classname + " " + date;
        }





    }
}
