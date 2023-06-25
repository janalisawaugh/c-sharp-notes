using System;

namespace LearnInheritance
{
  class Truck : Vehicle, IAutomobile
  { 
    public double Weight
    { get; }

    public Truck(double speed, double weight) : base(speed)
    {
      Weight = weight;
      Weight = weight<400? 8 : 12;

      
    }

     public override string Describe()
    {
      return $"This truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}";
    }

  }
}