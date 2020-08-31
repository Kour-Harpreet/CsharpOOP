using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class PrimaryStudent : Student
    {
        public bool NeedsNap { get; set; }

        // Overrides can be applied to both virtual and abstract methods, as well as prior overrides.
        public override void AttendClass()
        {
            base.AttendClass();
            Console.WriteLine("Attending class for me involves napping.");
        }
    }
}

