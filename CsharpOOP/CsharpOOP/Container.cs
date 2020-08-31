using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public abstract class Container
    {
        public int Capacity { get; set; }
        public int Contents { get; set; }

        public virtual void Search()
        {
            Console.WriteLine("You open the container.");
        }


    }
   
}

