//using IFlippable, Book, Diary and Dissertation
using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Diary dy1 = new Diary(5);
      Diary dy2 = dy1;
      dy2.Flip();
      Console.WriteLine(dy1.CurrentPage);
      Console.WriteLine(dy2.CurrentPage);

      Dissertation d1 = new Dissertation(50);
      Dissertation d2 = new Dissertation(50);
      Console.WriteLine(d1 == d2);
      /* Output: false because wuth references, comparison operators 
      do referential comparison which is checking if the 2 objects have 
      the same address in memory*/
      Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
	  Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
	  Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
	  Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");
      Book[] books = new Book[] {diss1, diss2, dy1, dy2};
      foreach(Book b in books)
      {
        Console.WriteLine(b.Title);     
      }
      /*Polymorphism is the ability in programming to present 
      the same interface for differing data types.*/
      /*
      Classes and interfaces are reference types. A variable of this type holds a reference to the data, not the data itself. This is different from value types like int and bool
      The equality operator (==) uses a referential comparison for reference types and a value comparison for value types
      Multiple references can be created for a single object
      A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference
      The functionality available to an object reference is determined by the reference’s type, not the object’s type
      Polymorphism is the ability in programming to present the same interface for differing data types
      Referencing an object by an inherited type or implemented interface is called upcasting. It can be done implicitly
      Referencing an object by a derived class is called downcasting, which must be made explicit by adding the type name in parentheses. It may cause an InvalidCastException error when the code is run
      To signify that a reference is “empty” or refers to no object, we set it equal to null
      If a reference is not set to any value it is unassigned and cannot perform any operations
      */
      
      //OBJECT TYPE
      Book bk = new Book();
      
      Diary dy = new Diary(38);
      
      int i = 9;
      Object o1 = bk;
      Object o2 = dy;
      Object o3 = i;

      /*
      Equals(Object) — returns true if the current instance and the argument are equal (using value equality for value types and referential equality for reference types)
      GetType() — returns the type of the object
      ToString() — returns a string describing the object
      */

      Book b = new Book();      
      Diary d = new Diary(38);
      Random r = new Random();
      int i = 9;

      Object[] objects = new Object[] {b,d,r,i};
      foreach (Object o in objects)
      {
        Console.WriteLine(o.GetType());
      }

      /*The Equals() and ToString() methods in Object are virtual, 
      so they can be overridden.*/

      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");

      Console.WriteLine(bk.ToString());

      //STRINGS
      /*
      A string reference will always point to the original object, 
      so “modifying” one reference to a string will not affect other references.
      Comparing strings with the equality operator (==) performs a value, 
      not referential, comparison.   
      Strings are immutable.   
      */

      string s1 = "immutable";
      string s2 = "immutable";
      Console.WriteLine(s1==s2);
      //prints True
      Object o1 = new Object ();
      Object o2 = new Object ();      
      Console.WriteLine(o1==o2);
      //prints False

      Console.WriteLine("Please enter a string: ");
      string input = Console.ReadLine();
      if (String.IsNullOrEmpty(input))
      {
        Console.WriteLine("You didn't enter anything!");
      }
      else
      {
        Console.WriteLine("Thank you for your submission!");
      }

      string lyrics = 
        "Dollie, Dollie, bo-bollie,\n" +
        "Banana-fana fo-follie\n" +
        "Fee-fi-mo-mollie\n" +
        "Dollie!";
      
      // Call `Replace()` here
      lyrics = lyrics.Replace("ollie", "ana");      
      
      Console.WriteLine(lyrics);










    }
  }
}

