//using Sedan.cs and IAutomobile.cs and Truck.cs

using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s1 = new Sedan(60);
      Sedan s2 = new Sedan(70);
      Truck truck = new Truck(45, 500);
      Console.WriteLine($"The first truck has a speed of {s1.Speed}, {s1.Wheels} wheels and license plate {s1.LicensePlate}");
      Console.WriteLine($"The first truck has a speed of {s2.Speed}, {s2.Wheels} wheels and license plate {s2.LicensePlate}");
      Console.WriteLine($"The first truck has a speed of {truck.Speed}, {truck.Wheels} wheels and license plate {truck.LicensePlate}");
      s1.SpeedUp();
      s2.SpeedUp();
      truck.SpeedUp();
      Console.WriteLine($"The new speeds for the 2 Sedans and truck respectively are {s1.Speed}, {s2.Speed} and {truck.Speed}");
 
    }
  }
}