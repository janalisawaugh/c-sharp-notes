using System;

namespace BasicClasses
{
  class Forest
  {
    
    public int trees;
    public int age;
    public string biome;
    private static int forestsCreated;
    private static string treeFacts;
    public string Name
    {get; set;} //automatic properties have the field name in the background so you don't have to declare it
    public int Trees
    {
      get {return trees;}
      set {trees = value;}
    }
    public string Biome
    {
      get{return biome;}
      set 
      {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    //static property
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    public static string TreeFacts
    {
      get {return treeFacts;}
    }
    //constructor
    public Forest(string name, string biome)
    {
      this. = name; //keyword 'this' refers to the current instance of the class
      this. = biome;
      Age = 0;
    }

    //overloading constructors
    public Forest (string name) : this(name, "Unknown")
    {
      Console.WriteLine("Biome not provided, value set to Unknown");
    }

    //static constructor
    //static constructor cannot have an access modifier
    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including: \r\n aiding in regulating climate.\r\n purifying water.\r\n mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
    }
    public int Grow()
    {
      Trees+=30;
      Age++;
      return Trees;
    }
    public int Burn()
    {
      Trees -=20;
      Age ++;
      return Trees;

    }
    //static method note they can only use static members
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }

    
    
  }

}
