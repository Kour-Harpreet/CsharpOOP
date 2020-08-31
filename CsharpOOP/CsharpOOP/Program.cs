using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    public class Program
    {
        static void Main(string[] args)

        {
            /*
               *Create a Container object that cannot be instantiated itself, only its children can be instantiated.
               *The Container will have a Capacity and Contents property and a Search() method.
           * The search method will write "You open the container."    
               *It's children will be "Box", "Chest" and "Cupboard".
              * Each child will have a constructor that will define capacity at:
                   Box: 6
                   Chest: 8
                   Cupboard: 4
               Override the search method and add "The $type contains {Contents} items of a maximum {Capacity}."
            Call the base version first.
                 Create a Fruit object that cannot be instantiated, with a Colour property. 
            Inherit Apple, Orange and Banana therefrom and construct their colours appropriately.

           */

            // Polymorphic lists contain multiple types of things.
            // Everything in the list MUST be a child type of the list type (in this case Fruit).
            Chest myChest = new Chest()
            {
                Contents = new List<Fruit>()
            };

            // Orange, Apple and Banana are children of Fruit and therefore can be added.
            myChest.Contents.Add(new Orange());
            myChest.Contents.Add(new Apple());
            myChest.Contents.Add(new Banana());

            foreach (Fruit fruit in myChest.Contents)
            {
                // Because Fruit contains the definition for Colour, all children have it and therefore we have easy access to that property on all elements in the list.
                Console.WriteLine(fruit.Colour);

                // GetType() will return the "Type" object of a variable (the datatype).
                // If you want to compare that with a class/datatype/etc, you must use typeof().
                if (fruit.GetType() == typeof(Apple))
                {
                    // Because only Apple has the Type property and not Banana or Orange (or Fruit), we must typecast the "fruit" iterator to an Apple in order to access the property.
                    // Attempting to typecast to the wrong type will throw an exception (hence the decision above).
                    Console.WriteLine(((Apple)fruit).Type);
                }
                else
                {
                    Console.WriteLine("Not an apple!");
                }

            }
            myChest.Search();

            // Polymorphic object reference. Lists are more common but these are used as properties sometimes, etc.
            Fruit aFruit = new Apple();

            // Depending who you ask, this is either the best thing ever, or should never be done ever.
            // EVERYTHING in C# inherits from "object" on one level or another, and therefore this list will accept anything you put in it.
            // Should you do it? Probably not, it's really messy. But it's cool to think about.
            List<object> superList = new List<object>();
            superList.Add(5);
            superList.Add("Hello");
            superList.Add(3.14);
            superList.Add('!');
            superList.Add(new Apple());


        }
    }
}