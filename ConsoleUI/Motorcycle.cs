using System;

namespace ConsoleUI;

public class Motorcycle :  Vehicle
{
    public Motorcycle()
    {
        
    }
    
    
    public string SpecialMotorcycleFeature { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("MOTORCYCLES ARE AWESOME!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("MOTORCYCLES ARE THE BEST!");
    }
}