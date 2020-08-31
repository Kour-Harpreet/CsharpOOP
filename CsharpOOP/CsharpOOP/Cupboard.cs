using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Cupboard : Container
    {
        public Cupboard()
        {
            Capacity = 4;
        }
        public override void Search()
        {
            base.Search();
            Console.WriteLine($"The Cupboard contains {Contents} items of a maximum {Capacity}.");
        }
    }
}
