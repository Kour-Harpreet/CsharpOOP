using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    public class Rectangle : Shape
    {
        public override double Area => Length * Width;

        public override double Perimeter => Length * 2 + Width * 2;


        public double Length { get; set; }


    
        public double Width { get; set; }
        public Rectangle(double width, double length, ColourValue colour)
        {
            Width = width;
            Length = length;
            Colour = colour;
        }
    }

}