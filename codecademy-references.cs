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
  }
}
