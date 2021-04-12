using System;
using System.Collections.Generic;
using System.Text;

namespace In_class_example___Classes
{
    public class Rectangle
    {
        //    private double _Length;

        //    // public double Length;

        //    public double GetLength()
        //    {
        //        return _Length;
        //    }

        //    public void SetLength(double length);
        //    {
        //        _Length = length;
        //    }
        //    private double Width;
        //}

        public double Length { get; set; }

        public double Width { get; set; }

       /// <summary>
       /// Default/ empty constructor for the rectangle class
       /// set the values of the properties/attributes to 
       /// </summary>
       
       
        public Rectangle() //  giving the varibales  defined above staring values 
        {
            Length =  7;  //unless we have values most of the time start a zero; 
            Width = 7 ;
        }
        /// <summary>
        /// overleaded the constructor for the recetnagle class
        /// sets the properties to the passed in values
        /// </summary>
        /// <param name="length"></param>
        /// <param name="Width"></param>
        public Rectangle(double length, double Width) // constructor 
        {
            Length =length;
            this.Width = Width;
            // if it is lowercase width do Width= width; save time by not doing it the other way

        }

        /// <summary>
        /// Calculate the area of this Rectangle Instance
        /// </summary>
        /// <returns> the area of the rectangle</returns>
       
        public double CalculateArea()
        {
            return Width * Length;

        }
        /// <summary>
        /// Calculate the perimeter of this rectangle instance
        /// </summary>
        /// <returns> the perimiter of the recetangle</returns>
        public double CalculatePerimiter()
        {
            return 2 * (Length + Width);
        }



    }

}
