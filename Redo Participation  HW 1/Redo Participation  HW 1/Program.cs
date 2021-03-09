using System;

namespace Redo_Participation__HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGIC_VALUE = 7.777;

            double val1;

            Console.WriteLine("Please enter a value>>");
            string valueone = Console.ReadLine();
            val1 = Convert.ToDouble(valueone);

            double val2;

            Console.WriteLine("Please enter a second value>>");
            string valuetwo = Console.ReadLine();
            val2 = Convert.ToDouble(valuetwo);

            double val3;

            Console.WriteLine("Please enter a third value>>");
            string valuethree = Console.ReadLine();
            val3 = Convert.ToDouble(valuethree);

            double sum = val1 + val2 + val3;
            Console.WriteLine($"The sum of your three numbers is {sum.ToString("N3")}");

            double multipliedsum = sum * MAGIC_VALUE;
            Console.WriteLine(multipliedsum.ToString("N3"));
        }




    }
}
