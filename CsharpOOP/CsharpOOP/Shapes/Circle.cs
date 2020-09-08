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

        public double Radius { get; set; }
        public Colour.ColourValue Colour { get; set; }


        public Circle(double radius, Colour.ColourValue colour)
        {
            Radius = radius;
            Colour = colour;
        }
    }
}