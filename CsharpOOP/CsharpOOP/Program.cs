using System;

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace CsharpOOP.Shapes
{
    class Program
    {
        static void Main(string[] args)
       
        {
            Circle myFirstShape = new Circle(5, Circle.ColourValue.Green);
            Circle mySecondShape = new Circle(5, Circle.ColourValue.Green);
            // Functionally the same as "myFirstShape == mySecondShape" except Microsoft decided not to include that default operator on struct.
            // Structs are compared by their properties, and not by their object reference. This means two structs with the same properties are treated as equal, unlike class/objects.
            Console.WriteLine(myFirstShape.Equals(mySecondShape));
        }
    }
}
