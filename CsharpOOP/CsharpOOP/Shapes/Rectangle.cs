using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    public struct Rectangle
    {
       
        public double Area => Length * Width;

        
        public double Perimeter => Length * 2 + Width * 2;

        private double Length { get; set; }

        private double Width { get; set; }
     
        public ColourValue Colour { get; set; }

        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }
        public Rectangle(double width, double length, ColourValue colour)
        {
            Width = width;
            Length = length;
            Colour = colour;
        }
    }

}