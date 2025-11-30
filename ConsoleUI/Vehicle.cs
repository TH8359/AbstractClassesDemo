using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year = "Generic Year";
    
    public string Make =  "Generic Make";
    
    public string Model =  "Generic Model";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("THIS IS THE DEFAULT VIRTUAL METHOD");
    }
}