using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class Program
    {
        static void Main(string[] args)

        {
            SecondaryStudent theStudent = new SecondaryStudent();

            // Because PrimaryStudent and SecondaryStudent both inherit from Student, they both have StudentID.
            // Because Student inherits from Person, Student and all its child classes have FirstName and LastName.
            theStudent.FirstName = "Jimmy";
            theStudent.LastName = "Jones";
            theStudent.StudentID = 10001;
            // Being that NeedsNap is defined in PrimaryStudent, SecondaryStudent does not have it.

            theStudent.AttendClass();

            Console.WriteLine("-------");

            PrimaryStudent youngStudent = new PrimaryStudent();
            // But PrimaryStudent does, along with all the other Student stuff.
            youngStudent.NeedsNap = true;
            youngStudent.AttendClass();
        }
    }
}