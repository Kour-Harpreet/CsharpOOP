using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.Shapes
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public ColourValue Colour { get; set; }

        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }
    }
}