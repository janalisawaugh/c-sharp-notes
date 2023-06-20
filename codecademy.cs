using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      //arrays
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      string [] summerStrutCopy = new string[8];
      Array.Copy(summerStrut, summerStrutCopy, 8);
      Console.WriteLine($"first song of summerStrut copy is {summerStrutCopy[0]}");
      Array.Reverse(summerStrut);
      Console.WriteLine($"first song and last song of summerStrut are {summerStrut[0]} and {summerStrut[7]}");
      Array.Clear(ratings, 0, 8);
      Console.WriteLine(ratings[0]);

      //do while loops
      bool buttonClick = true;
      do
      {
        Console.WriteLine("BEEP BEEP BEEP BEEP");
      } while(!buttonClick);
      Console.WriteLine("Time for a 5 minute break.");

      //while loops
      int emails = 20;  
      while (emails!=0)
      {
        emails --;
        Console.WriteLine("Deleting email...");
      }
      Console.WriteLine("INBOX ZERO ACHIEVED!");

      //for loops
      for (int i = 1; i<17; i++)
      {
        CreateTemplate(i);
      }

      //foreach loops
      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

      foreach(string task in todo)
      {
        CreateTodoItem(task);
      }

      /*
        while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
        do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
        for loops are best if you want something to run a specific number of times, rather than given a certain condition.
        foreach loops are the best way to loop over an array, or any other collection.
      */

      //jump statements (break, continue, return)
      bool buttonClick = false;
      int alarmCount = 0;
      
      do
      {
        if (alarmCount == 3)
        {
          break;
        }
        Console.WriteLine("BLARRRRR");
        alarmCount++;

        
      } while(!buttonClick);


      

    }
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }

    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }




  }
}
