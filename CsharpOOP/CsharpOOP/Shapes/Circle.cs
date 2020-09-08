using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
  
    public struct Circle
    {
      
        public double Area => Math.PI * Math.Pow(Radius, 2);
        public double Circumference => 2 * Math.PI * Radius;
       
        public double Perimeter => Circumference;
        /*
        Same as:
        {
            get
            {
                return Circumference;
            }
        }
        */

        private double Radius { get; set; }
        public ColourValue Colour { get; set; }

        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }
        public Circle(double radius, ColourValue colour)
        {
            Radius = radius;
            Colour = colour;
        }
    }
}