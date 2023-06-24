using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {

    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }


  	public string LicensePlate
    { get; }

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
      Speed-=5;
    }

    
  }
}