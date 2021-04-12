using System;

namespace In_class_example___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create first instance of rectangle
            Rectangle rect1 = new Rectangle(); // empty parthenses is calling the default or the constructor
            //rectangle is class 
            // rect1 and rect2 are the instances in the rectangle class
            rect1.Length = 5;
            rect1.Width = 5;     // if we dont have this line then it will calculate the value when it is set to 7 because it is our starting value
            double area = rect1.CalculateArea();
            Console.WriteLine($"Rectangle 1: W:{rect1.Width}, L:{rect1.Length}, A:{area} , P:{rect1.CalculatePerimiter()} ");

            //creates second instance of Rectangle
            Rectangle rect2 = new Rectangle(25.5, 3.33);
            Console.WriteLine($"Rectangle 1: W:{rect2.Width}, L:{rect2.Length}, A:{rect2.CalculateArea()} , P:{rect2.CalculatePerimiter()} ");

            Circle circ1 = new Circle();
            circ1.Radius = 3.33;
            Console.WriteLine($" Circle 1: R:{circ1.Radius} , A:{circ1.CalculateArea()}, P{circ1.CalculatePerimter()}");

            Circle circ2 = new Circle();
            circ2.Radius = 9.66;
            Console.WriteLine(circ2);
            Console.WriteLine($" Circle 2: R:{circ2.Radius} , A:{circ2.CalculateArea()}, P{circ2.CalculatePerimter()}");


            //double area = circ1.CalculateArea();
            //double perimter = circ1.CalculatePerimter();
        }
    }
}
