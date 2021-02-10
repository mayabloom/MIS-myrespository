﻿using System;

namespace In_Class_Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumberBetween1and100 = rand.Next(1, 101);

            if (randomNumberBetween1and100 % 3 ==0)
            {
                Console.WriteLine("Fizz");
            }

            if (randomNumberBetween1and100 % 5 ==0)
            {
                Console.WriteLine("Buzz");
            }

            if (randomNumberBetween1and100 % 3 == 0
                && randomNumberBetween1and100 % 5 ==0)
            {
                Console.WriteLine("Fizz Buzz");
            }

            else
            {
                Console.WriteLine($"{randomNumberBetween1and100}");
            }
        }
    }
}
