using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle [COMPLETE]
             * The vehicle class shall have three string properties: Year, Make, and Model [COMPLETE]
             * Set the defaults of the properties to something generic in the Vehicle class [COMPLETE]
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation. [COMPLETE]
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. [COMPLETE]
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle [COMPLETE]
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle [COMPLETE]
             * Provide the implementations for the abstract methods [COMPLETE]
             * Only in the Motorcycle class will you override the virtual drive method [COMPLETE]
            */

            // Create a list of Vehicle called vehicles [COMPLETE]
            
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes [COMPLETE]
             * 
             * Set the properties values with object initializer syntax [COMPLETE]
             */
            
            Car carOne = new Car() { Year = "2000", Make = "Make One", Model = "Model One", SpecialCarFeature = "More Room" };
            Motorcycle motorcycleOne = new Motorcycle() { Year = "2005", Make = "Make Two", Model = "Model Two", SpecialMotorcycleFeature = "Looks Cool" };
            Vehicle vehicleOne = new Motorcycle() { Year = "2010", Make = "Make Three", Model = "Model Three", SpecialMotorcycleFeature = "Looks Cool" };
            Vehicle vehicleTwo = new Car() { Year = "2015", Make = "Make Four", Model = "Model Four", SpecialCarFeature = "More Room" };

            /*
             * Add the 4 vehicles to the list [COMPLETE]
             * Using a foreach loop iterate through the list and display each of the properties [COMPLETE]
             */

            // Call each of the drive methods for one car and one motorcycle [COMPLETE]
            
            vehicles.Add(carOne);
            vehicles.Add(motorcycleOne);
            vehicles.Add(vehicleOne);
            vehicles.Add(vehicleTwo);

            

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Year);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                if (vehicle.Year == "2000" || vehicle.Year == "2015")
                {
                    Console.WriteLine(carOne.SpecialCarFeature);
                }
                else
                {
                    Console.WriteLine(motorcycleOne.SpecialMotorcycleFeature);
                }

            }

            carOne.DriveAbstract();
            carOne.DriveVirtual();
            
            motorcycleOne.DriveAbstract();
            motorcycleOne.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
