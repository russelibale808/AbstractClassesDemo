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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var car = new Car();

            car.Name = "Toyota";
            car.Year = " 1990";
            car.Model = " Corolla";
            car.HasTrunk = true;

            Vehicle Nissan = new Car();
            Nissan.Name = "Nissan";
            Nissan.Year = " 1992";
            Nissan.Model = " Sentra";
            Nissan.numberOfWheels = 4;


            Motorcycle Ninja = new Motorcycle();
            Ninja.Name = "Ninja";
            Ninja.Year = " 2011";
            Ninja.IsDrivable = true;

            var motorcycle = new Motorcycle();

            motorcycle.Name = "Harley";
            motorcycle.Year = " 2004";
            motorcycle.Model = " Roadster";
            motorcycle.HasSideCart = true;


            var carList = new List<Vehicle>();

            carList.Add(car);
            carList.Add(motorcycle);
            carList.Add(Nissan);
            carList.Add(Ninja);


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            foreach ( var veh in carList)
            {
                Console.WriteLine($"{veh.Name}{veh.Year}{veh.Model}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("---------------------------");
                Console.WriteLine();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
