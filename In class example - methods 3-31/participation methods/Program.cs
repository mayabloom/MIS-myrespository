using System;

namespace participation_methods
{
    class Program


    {
        static void Main(string[] args)
        {
            double sum = Add(3, 4); //argument
            Console.WriteLine(sum);

            double sub = Subtract(7, 4);
            Console.WriteLine(sub);

            double mul = Multiply(3, 5);
            Console.WriteLine(mul);

            double div = Divide(10, 5);
            Console.WriteLine(div);

            int answer;

            Console.WriteLine(" What calculation would you like to perform?");
            Console.WriteLine(" 1 for Addition");
            Console.WriteLine(" 2 for Subtraction");
            Console.WriteLine(" 3 for Multiplication");
            Console.WriteLine(" 4 for Division");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1 )
            {
                Console.WriteLine(sum);
            }
            else if (answer == 2)
            {
                Console.WriteLine(sub);
            }

            else if (answer == 3)
            {
                Console.WriteLine(mul);
            }
            else
            {
                Console.WriteLine(div);
            }

            

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

       


    }
}
