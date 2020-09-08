using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CsharpOOP.Shapes
{
    class Drawing
    {
        // Arrow notation implies that the right side of the arrow is the return statement of a "get". No set is implied.
        public double SpaceCovered => Shapes.Select(x => x.Area).Sum();
        public double LinesDrawn => Shapes.Select(x => x.Perimeter).Sum();

        // Example of Polymorphism

        public List<Shape> Shapes { get; set; }

        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }
        public Drawing()
        {
            Shapes = new List<Shape>();
        }
        // Colour ratio is achieved by using the same logic as SpaceCovered, but Where()ing to only Red/Green/Blue shapes first:
        // Shapes.Where(x => x.Colour == Shape.ColourValue.Green).Select(x => x.Area).Sum()
        // Then dividing by the total area covered, and multiplying by 100.
        public override string ToString() => $"A drawing consisting of { Shapes.Count } shapes that is {Shapes.Where(x => x.Colour == Shape.ColourValue.Red).Select(x => x.Area).Sum() / SpaceCovered * 100:F2}% red, {Shapes.Where(x => x.Colour == Shape.ColourValue.Green).Select(x => x.Area).Sum() / SpaceCovered * 100:F2}% green and {Shapes.Where(x => x.Colour == Shape.ColourValue.Blue).Select(x => x.Area).Sum() / SpaceCovered * 100:F2}% blue.";
    }
}