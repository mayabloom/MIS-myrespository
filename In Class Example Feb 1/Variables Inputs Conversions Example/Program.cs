﻿using System;

namespace Variables_Inputs_Conversions_Example
{
    class Program
    {
        static void Main(string[] args)

            int heresMyInt;
            double heresMyDouble;
     
            Console.WriteLine($"Please enter a double >>");
            string answer = Console.ReadLine();
            heresMyDouble = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter an integer >>");
            answer = Console.ReadLine();
            heresMyInt = Convert.ToInt32(answer);

            double result = heresMyDouble + heresMyInt;

            Console.WriteLine("The result of " + heresMyDouble.ToString("N3") + "+ "
                heresMyInt.ToString() + " = " + result.ToString("C5"));
        }
    }
}
