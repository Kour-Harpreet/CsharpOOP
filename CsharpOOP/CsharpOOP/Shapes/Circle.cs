using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
  
    public class Circle:Shape
    {

        public override double Area => Math.PI * Math.Pow(Radius, 2);
        public double Circumference => 2 * Math.PI * Radius;
        public override double Perimeter => Circumference;
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

        public Circle(double radius, ColourValue colour)
        {
            Radius = radius;
            Colour = colour;
        }
    }
}