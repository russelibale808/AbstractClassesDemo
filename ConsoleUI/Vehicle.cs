using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Name { get; set; } = " Generic Name";
        public string Year { get; set; } = " 2000";
        public string Model { get; set; } = " Generic Model";

        public bool IsDrivable = true;

        public int numberOfWheels = 4;

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} is dirving virtualy");
        }


    }
}
