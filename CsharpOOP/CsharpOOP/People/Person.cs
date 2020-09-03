using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP.People
{
    public class Person
    {
        // A default property auto-generates the backing variable as a private variable of the same type.
        // The getter and setter are also automatically generated.
        public string FirstName { get; set; }
        // The above auto-generated property can be likened to the following:
        private string _lastName;
        public string LastName
        {
            get // Output of the value.
            {
                // The "getter" is called whenever the user tries to use the property.
                // Example: writing it out, assigning another variable to it, etc.
                // (string myVar = student.LastName)
                // Do any formatting of values here.
                return _lastName;

            }
            set // Input to the value.
            {
                // The "setter" is called whenever the user tries to assign the property.
                // 'value' is a keyword that represents what the user is trying to assign thereto.
                // Do any validation of values here.
                _lastName = value;

            }
        }
        // Properties can be declared without a setter. In this case, it is build from two other properties.
        // As far as a user of the class is concerned, this has data, it has a value. They don't have to know that it's not stored somewhere, they just have to use it.
        // By omitting the setter from the prop declaration, C# will not auto-implement the setter, and therefore there will be no backing variable (hidden or otherwise) taking up memory.
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Private properties can only be set in this class.
        public DateTime DateOfBirth { get; set; }
    }
}
