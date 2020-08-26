using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Homework
    {
        /*
        Practice Task:
       Add a "Pending Homework" property that is a stack of homework objects. *

       The homework class will have a complexity property of 1-5. |*

        Please validate and clamp to 1 if less than 1, and 5 if greater than 5.*

       Modify the DoHomework method so that it will take the top homework off the stack,

        and the number of characters being written will be the complexity times 100.

        Energy level will decrease by complexity times 10, 

        and stress will increase by complexity times 5.
       */
       

        private int _complexity;
        public int Complexity
        {

            get
            {
                return _complexity;
            }
            set
            {
                if (value < 1)
                {
                    _complexity = 1;
                }
                else if (value > 5)
                {
                    _complexity = 5;
                }
                else
                {
                    _complexity = value;
                }
            }
        }
        
    }
}
