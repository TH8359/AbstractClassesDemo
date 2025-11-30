using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public Car()
    {
        
    }
    
    public string SpecialCarFeature { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("CARS ARE AWESOME!");
    }
}