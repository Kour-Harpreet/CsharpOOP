using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace CsharpOOP.Shapes
{
    class Program
    {
        static void Main(string[] args)
        { 
               // Change this path if you run the code on your computer.
               // Without a drive letter, it will be relative to your /bin/ folder.
        Console.WriteLine(ReadFromFile("C:\\TECHCareers\\TheDrawing.txt"));
        }
    static void WriteToFile(Drawing theDrawing, string path)
    {
        // Create a stream writer (open the file).
        using (StreamWriter writer = new StreamWriter(path))
        {
            // For each shape in the drawing, we're going to write a line to the file with its property values.
            foreach (Shape theShape in theDrawing.Shapes)
            {
                string toWrite = $"{theShape.GetType()}";
                // Since the shapes have different properties, we'll have to determine what to write on a per-shape basis.
                if (theShape.GetType() == typeof(Circle))
                {
                    toWrite += "," + theShape.Colour + "," + ((Circle)theShape).Radius;
                }
                else if (theShape.GetType() == typeof(Rectangle))
                {
                    toWrite += "," + theShape.Colour + "," + ((Rectangle)theShape).Width + "," + ((Rectangle)theShape).Length;
                }
                else if (theShape.GetType() == typeof(Triangle))
                {
                    toWrite += "," + theShape.Colour + "," + ((Triangle)theShape).Width + "," + ((Triangle)theShape).Height;
                }
                else
                {
                    throw new Exception("Cannot parse shape. Unknown type.");
                }
                writer.WriteLine(toWrite);
            }
        }
    }
    static Drawing ReadFromFile(string path)
    {
        Drawing theDrawing = new Drawing();
        // Create the reader (opens the file).
        using (StreamReader reader = new StreamReader(path))
        {
            string line = "";
            // Read a new line until the end of the file, do this for each line in the file.
            while ((line = reader.ReadLine()) != null)
            {
                // Split our comma separated values into an array of values.
                string[] values = line.Split(',');
                Shape.ColourValue colour = Shape.ColourValue.Red;
                // Determine colour (second value in the line):
                switch (values[1])
                {
                    case "Red":
                        colour = Shape.ColourValue.Red;
                        break;
                    case "Green":
                        colour = Shape.ColourValue.Green;
                        break;
                    case "Blue":
                        colour = Shape.ColourValue.Blue;
                        break;
                }
                // Determine shape (first value in the line) and draw the shape (the rest of the values in the line starting with third):
                switch (values[0])
                {
                    case "CSharpOOP.Shapes.Circle":
                        theDrawing.Draw(new Circle(double.Parse(values[2]), colour));
                        break;
                    case "CSharpOOP.Shapes.Rectangle":
                        theDrawing.Draw(new Rectangle(double.Parse(values[2]), double.Parse(values[3]), colour));
                        break;
                    case "CSharpOOP.Shapes.Triangle":
                        theDrawing.Draw(new Triangle(double.Parse(values[2]), double.Parse(values[3]), colour));
                        break;
                }
            }
            return theDrawing;
        }
    }
}
}