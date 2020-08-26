﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class Program
    {
        static void Main(string[] args)
       
        {
            Homework myHomework = new Homework();
            // Stacks are "Last-In, First-Out"
            Stack<string> myHomeworkStack = new Stack<string>();

            // Push means "add to".
            myHomeworkStack.Push("First String");
            myHomeworkStack.Push("Second String");
            myHomeworkStack.Push("Third String");

           

            // Pop means "take the next" (return it, and remove it).
        

           

            // Dictionaries are sort of like lists, except rather than indexed by an integer, they can be indexed by other things.
            string testString = "TechCareers teach code";


            // Create a dictionary indexed by characters (instead of ints like everything else).
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                charCounts.Add(i, 0);
            }

            // For each character in our test string:
            foreach (char character in testString)
            {
                if (charCounts.ContainsKey(char.ToLower(character)))
                {
                    // Increment that character count.
                    charCounts[char.ToLower(character)]++;
                }

            }
            // You can index dictionaries by ints as well, if you don't want to start numbering at 0.
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1001, "John Doe");
            students.Add(1002, "Jane Doe");


            Console.WriteLine(students[1002]);
            // Displays the value associated with the key 's'.
            Console.WriteLine(charCounts['s']);


            Teacher.Test();

        }
    }
}
