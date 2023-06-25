using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {

    public Truck(double speed, double weight)
    {
      Speed = speed;
      Weight = weight;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = Weight<400? 8 : 12;
    }

  	public string LicensePlate
    { get; }

    public double Weight
    {get;}

    public double Speed
    { 
      get {return Speed;}
      private set {Speed = value;} 
    }

    public int Wheels
    { get; }
     
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      Speed +=5;
    }

    public void SlowDown()
    {
      Speed -=5;
    }

  }
}