using System;

namespace CsharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // In-Class Practice Round 2:

            // Try to do it without any variables at all (remove the line above these comments).
            // Two lines (prompt and output).

            Console.Write("Please enter a string: ");
            Console.WriteLine(Console.ReadLine().Trim().Contains(' ') ? "Multiple words." : "One word.");

        }
    }
}
