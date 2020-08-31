using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class Program
    {
        static void Main(string[] args)

        {

            // Method and properties can have keywords added to them in classes that impact their behaviour and abilities. 
            // A "virtual" method/property can be overriden in a child class, but has a implementation in the parent class.
            // For example, a virtual method might be something like movement where all characters will move up when the MoveUp() method is called, but may have other things occur when they do. Parent virtual methods typically implement behaviour that is common to all child objects.

            // A "abstract" method/property MUST be overriden / implemented in the child class(es), because it has no implementation in the parent class.
            // For example, an abstract method might be something like an attack method where there is no common functionality between all children, but they should all have their own way of doing it.

            // A "override" method/property is overwriting / adding to functionality from a base class.

            // An "abstract" class means that it cannot be instantiated itself, only its children can be instantiated.


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

            // In this case, the Student class is abstract, so it cannot be instantiated itself. We must be more specific and instantiate either a PrimaryStudent or SecondaryStudent.
            Student randomStudent = new Student();

        }
    }
}