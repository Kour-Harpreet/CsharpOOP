using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public struct Colour
    {
        // We're declaring an enumerator here, which we use in each shape.
        // It's not an object reference, but rather a value of this enumerator type.
        // This allows us to compare the colours of multiple shapes, because the comparison is handled by this enumerator.
        // If each shape had its own enumerator declaration, C# wouldn't know how to implicitly compare them.
        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }
    }
}