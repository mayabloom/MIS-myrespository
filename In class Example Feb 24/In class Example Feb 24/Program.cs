using System;

namespace In_class_Example_Feb_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <=100; i++)
            {
                sum = sum + i;
                //sum +=i;
            }
            Console.WriteLine($" All the #'s added up from 1 to 100 is {sum.ToString("n2")}");
        }
    }
}
