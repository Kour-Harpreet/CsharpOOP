using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Person
    {
        // If we want to open this method up to be overridden, it must be marked as "virtual".
        public virtual void AttendClass()
        {
            Console.WriteLine("Attending class for me involves doing school work.");
        }
    }
}
