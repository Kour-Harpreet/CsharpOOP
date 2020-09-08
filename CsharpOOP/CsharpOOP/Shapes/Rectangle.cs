using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    public struct Rectangle
    {
       
        public double Area => Length * Width;

        
        public double Perimeter => Length * 2 + Width * 2;

        public double Length { get; set; }

        public double Width { get; set; }

        public Colour.ColourValue Colour { get; set; }

        public Rectangle(double width, double length, Colour.ColourValue colour)
        {
            Width = width;
            Length = length;
            Colour = colour;
        }
    }

}