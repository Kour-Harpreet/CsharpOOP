using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Apple : Fruit
    {
        public string Type { get; set; }
        public Apple()
        {
            Colour = "Red";
            Type = "Red Delicious";
        }
    }
}
