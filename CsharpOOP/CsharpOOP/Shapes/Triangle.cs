using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    // Example of Inheritance
    public class Triangle : Shape
    {
        public override double Area => Height * Width / 2;
        public override double Perimeter => Height + Width + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));

        // Example of Abstraction
       
        public double Height { get; set; }

       
        public double Width { get; set; }

        // Example of Encapsulation
       
        public Triangle(double width, double height, ColourValue colour)
        {
            Width = width;
            Height = height;
            Colour = colour;
        }
    }
}