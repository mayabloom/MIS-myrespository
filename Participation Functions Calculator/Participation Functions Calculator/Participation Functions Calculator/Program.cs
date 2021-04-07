using System;

namespace Participation_Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            DeveloperInformation("Maya Bloom", "MIS3013", "4/6/2021");
            




            //double sum = Add(valueone, valuetwo); //argument
            //double sub = Subtract(7, 4);
            //double mul = Multiply(3, 5);
            //double div = Divide(10, 5);

            string answer;
            string input;
            double valueone;
            double valuetwo;

            
            do
            {
                Console.WriteLine(" What calculation would you like to perform? (e.g. addition, subtraction, multiplication, division >>)");
                answer = Console.ReadLine().ToLower();

                Console.WriteLine("Please input your first value>>");
                valueone = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please input your second value >>");
                valuetwo = Convert.ToDouble(Console.ReadLine());

                double result = Add(valueone, valuetwo); //argument
                 result = Subtract(valueone, valuetwo);
                 result = Multiply(valueone, valuetwo);
                 result = Divide(valueone, valuetwo);


                if (answer == "addition")
                {
                    result = Add(valueone, valuetwo);
                    Console.WriteLine($" The answer is  {result}");
                }
                else if (answer == "subtraction")
                {
                    result = Subtract(valueone, valuetwo);
                    Console.WriteLine($" The answer is  {result}");
                }

                else if (answer == "multiplication")
                {
                    result = Multiply(valueone, valuetwo);
                    Console.WriteLine($" The answer is  {result}");
                }
                else
                {
                    result = Divide(valueone, valuetwo);
                    Console.WriteLine($" The answer is  {result}");
                }

                Console.WriteLine("Do you want to do another calculation? Yes or No >>");
                input = Console.ReadLine();

                Console.WriteLine("What calculation would you like to perform?");
                string answeragain = Console.ReadLine();


                Console.WriteLine("Do you want to use your previous answer as the first value in the next calculation?");
                string previousanswer = Console.ReadLine();

                if (previousanswer[0] == 'y')
                {
                    Console.WriteLine("What is your second value>>");
                    double nextvalue = Convert.ToDouble(Console.ReadLine());

                    double newresult = Add(result, nextvalue); //argument
                     newresult = Subtract(result, nextvalue);
                     newresult = Multiply(result, valuetwo);
                     newresult = Divide(result, valuetwo);


                    if (answeragain == "addition")
                    {
                        result = Add(result, nextvalue);
                        Console.WriteLine(result);
                    }
                    else if (answeragain == "subtraction")
                    {
                        result = Subtract(result, nextvalue);
                        Console.WriteLine(result);
                    }

                    else if (answeragain == "multiplication")
                    {
                        result = Multiply(result, nextvalue);
                        Console.WriteLine(result);

                    }
                    else
                    {
                        result = Divide(result, nextvalue);
                        Console.WriteLine(result);
                    }

                   

                }
                else
                {
                    Console.WriteLine("Please input your first value>>");
                    valueone = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please input your second value >>");
                    valuetwo = Convert.ToDouble(Console.ReadLine());

                    if (answer == "addition")
                    {
                        result = Add(valueone, valuetwo);
                        Console.WriteLine($" The answer is  {result}");
                    }
                    else if (answer == "subtraction")
                    {
                        result = Subtract(valueone, valuetwo);
                        Console.WriteLine($" The answer is  {result}");
                    }

                    else if (answer == "multiplication")
                    {
                        result = Multiply(valueone, valuetwo);
                        Console.WriteLine($" The answer is  {result}");
                    }
                    else
                    {
                        result = Divide(valueone, valuetwo);
                        Console.WriteLine($" The answer is  {result}");
                    }

                }

                Console.WriteLine("Do you want to do another calculation? Yes or No >>");
                input = Console.ReadLine();



                if (input.ToLower()[0] == 'n')
                {
                    Console.WriteLine(" Thank you for using this service");
                }


            } while (input.ToLower()[0]=='y');

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"> The left hand operand of the equation</param>
        /// <param name="val2"> The righ hand operand of the equation </param>
        /// <returns> the sum of the two operands </returns>
        static double Add(double val1, double val2) //parameters are val1 and val2 
        {
            double number = val1 + val2;
            return number;


            //return val1 + val2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"> the left hand operand </param>
        /// <param name="val2"> the right hand operand </param>
        /// <returns> returns the subtraction of the right hand operand from the left hand operand </returns>
        static double Subtract(double val1, double val2)
        {
            double number = val1 - val2;
            return number;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"> the left hand operand </param>
        /// <param name="val2"> the right hand operand</param>
        /// <returns> the two operands multiplied together </returns>
        static double Multiply(double val1, double val2)
        {
            double number = val1 * val2;
            return number;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"> the left hand operand </param>
        /// <param name="val2"> the right hand operand </param>
        /// <returns> the left hand operand dividied by the right hand operand</returns>
        static double Divide(double val1, double val2)
        {
            double number = val1 / val2;
            return number;
        }

        static void  DeveloperInformation(string userinfo, string classname, string date)
        {
            Console.WriteLine($"{userinfo} wrote this application for {classname} on {date}");
        }




    }
}
