using System;

namespace In_class_Example_Loops_Feb_22
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexOutOfRangeException i = 3;
            while (i<=1000)
            {
                Console.WriteLine(i);
                i += 3;

            }

            int favoriteNumber;
            Console.WriteLine("What's your favorite number?>>");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out favoriteNumber) == false
            {
                Console.WriteLine("Incorrect value. You must enter an integer");
                answer = Console.ReadLine();
            }
               
            
            // string userAnswer = " ";

                //do
                {
                    //Console.WriteLine("Knock Knock. Who's there? >>");
                   // userAnswer = Console.ReadLine();
                } //while (userAnswer.ToLower() != "banana"));
       

                // Console.WriteLine("Knock Knock. Who's there? >>");
                //userAnswer = Console.ReadLine();

                //while (userAnswer.ToLower() != "banana") 
                {
                    //Console.WriteLine(" Knock Knock. Who's there? >>");
                    //userAnswer = Console.ReadLine();
                }
            }
        }
    }

    //} 

    //for (int i = 0; i <=  1000; i = i+3 )
    {
       //if ( i % 3 ==0 )
        {
            //Console.WriteLine($"{i} is a multiple of 3 ");
       
        }
    }
