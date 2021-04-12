using System;
using System.Collections.Generic;
using System.Text;

namespace In_class_example___Classes
{
     public class Circle
    {
        public double Radius { get; set; }
        /// <summary>
        /// empty constructure that sets the starting value of radius to 0
        /// </summary>
        public Circle()
        {
            Radius = 0;

        }

        /// <summary>
        /// calculates the area of the circle
        /// </summary>
        /// <returns> the area of the circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);

        }
        /// <summary>
        /// Calculates the perimter of the circle
        /// </summary>
        /// <returns> the perimter of this circle </returns>

        public double CalculatePerimter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    
}
