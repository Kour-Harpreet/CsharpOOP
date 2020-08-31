using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Box : Container
    {
        public Box()
        {
        Capacity = 6;
        }
        public override void Search()
        {
            base.Search();
            Console.WriteLine($"The Box contains {Contents} items of a maximum {Capacity}.");
        }
    }
}
