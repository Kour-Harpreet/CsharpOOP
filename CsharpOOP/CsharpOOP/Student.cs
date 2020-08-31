using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
     public class Student : Person
    {
        public int StudentID { get; set; }

        public override void AttendClass()
        {
            base.AttendClass();
            Console.WriteLine("Attending class for me involves napping.");
        }
    }
}

