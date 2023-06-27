using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List <double> marathons = new List <double>();
      marathons.Add(144.07);
      marathons.Add(143.12);
      Console.WriteLine(marathons[1]);

      //object initialization
      List<double> marathons = new List<double> {144.07, 143.12, 146.73, 146.33};
      Console.WriteLine(marathons.Count);
      marathons.Add(143.23);
      Console.WriteLine(marathons.Contains(143.23));
      Console.WriteLine(marathons.Count);
      Console.WriteLine(marathons[1]);
      bool removed = marathons.Remove(143.12);
      Console.WriteLine(marathons[1]);
      Console.WriteLine(removed);
      marathons.Clear(); //removes all elements from the list
      /*
      4 COMMON LIST RANGE OPERATIONS
      AddRange() — takes an array or list as an argument. Adds the values to 
      the end of the list. Returns nothing.
      InsertRange() — takes an int and array or list as an argument. 
      Adds the values at the int index. Returns nothing.
      RemoveRange() — takes two int values. The first int is the index at 
      which to begin removing and the second int is the number of elements 
      to remove. Returns nothing.
      GetRange() — takes two int values. The first int is the index 
      of the first desired element and the second int is the number of 
      elements in the desired range. Returns a list of the same type.      
      */
      List <double> topMarathons = marathons.GetRange(0,3);
      foreach (double m in topMarathons)
      {
        Console.WriteLine(m);
      }

      List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
      Random rand = new Random();
      
      Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
      // First loop
      foreach (string name in runners)
      {
        Console.WriteLine($"{runners.IndexOf(name)}: {name}");
      }
      
      Console.WriteLine("\nPrinting runner bibs...");
      
      // Second loop
      foreach (string name in runners)
      {        
        int id = rand.Next(100, 1000);
        Console.WriteLine($"{id} - {name.ToUpper()}");
      }
      List <bool> bools = new List<bool>();
      List <Random> randos = new List<Random>();
      List <IServiceProvider> isps = new List<IServiceProvider>();

      /*
      Use lists and dictionaries in your code by including this 
      line at the top of your file:
      using System.Collections.Generic;

      A list, or List<T>, is a generic, sequential data structure. 
      The specific type that it contains is specified upon instantiation.
      */
      
    }
  }
}
