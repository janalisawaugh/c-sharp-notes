using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
      // Approach 1: without LINQ
      List<string> longLoudHeroes = new List<string>();
      
      foreach (string hero in heroes)
      {
        if (hero.Length > 6)
        {
          string formatted = hero.ToUpper();
          longLoudHeroes.Add(formatted);
        }
      }
      
      // Approach 2: with LINQ
      var longLoudHeroes2 = from h in heroes
            where h.Length > 6
            select h.ToUpper();
      
      // Printing...
      Console.WriteLine("Your long loud heroes are...");
      
      foreach (string hero in longLoudHeroes2)
      {
        Console.WriteLine(hero);
      }

      var shortHeroes = from h in heroes
        where h.Length < 8
        select h;
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }
      var longHeroes = heroes.Where(n => n.Length > 8);
      Console.WriteLine(longHeroes.Count());

      // Query syntax
      var queryResult = from x in heroes
                        where x.Contains("a")
                        select $"{x} contains an 'a'";
      
      // Method syntax
      var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");
     
      // Printing...
      Console.WriteLine("queryResult:");
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }
      
      Console.WriteLine("\nmethodResult:");
      foreach (string s in methodResult)
      {
        Console.WriteLine(s);
      }

      var heroesWithI = from hero in heroes
        where hero.Contains("i")== true
        select hero;
      var underscored = from hero in heroes
        select hero.Replace(" ", "_");
      foreach (string h in heroesWithI)
      {
        Console.WriteLine(h);
      }
      foreach (string h in underscored)
      {
        Console.WriteLine(h);
      }

      var heroesWithI = heroes.Where(h => h.Contains("i"));
      foreach (string h in heroesWithI)
      {
        Console.WriteLine(h);
      }

      //separate statement strategy
      var lowerHeroesWithC = heroes.Where(h => h.Contains("c"));
      lowerHeroesWithC = lowerHeroesWithC.Select(h => h.ToLower());

      //chain expression strategy
      var sameResult = heroes
        .Where(h => h.Contains("c"))
        .Select(h => h.ToLower());
      foreach (string h in lowerHeroesWithC)
      {
        Console.WriteLine(h);
      }
      foreach (string h in sameResult)
      {
        Console.WriteLine(h);
      }

      var intro = heroes.Select(h => $"Introducing...{h}!");
      var spaces = from h in heroes
        where h.Contains(" ")
        select h.IndexOf(" ");

      foreach (string h in intro)
      {
        Console.WriteLine(h);
      }
      foreach (int h in spaces)
      {
        Console.WriteLine(h);
      }

      





    }
  }
}
