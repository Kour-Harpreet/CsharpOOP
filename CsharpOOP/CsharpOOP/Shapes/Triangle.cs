using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    public struct Triangle
    {
        
        public double Area => Height * Width / 2;
        public double Perimeter => Height + Width + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));

        // Example of Abstraction
        private double Height { get; set; }

        private double Width { get; set; }
        public Colour.ColourValue Colour { get; set; }


        // Example of Encapsulation

        public Triangle(double width, double height, Colour.ColourValue colour)
        {
            Width = width;
            Height = height;
            Colour = colour;
        }
    }
}