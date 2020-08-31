using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class SecondaryStudent : Student
    {
        public bool FrenchImmersion { get; set; }

        public bool StudentCouncilMember { get; set; }

        // Overrides can be applied to both virtual and abstract methods, as well as prior overrides.
        public override void AttendClass()
        {
            base.AttendClass();
            Console.WriteLine("Attending class for me involves lots of social drama.");
        }
    }
}

