using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine($" This {GetType().Name} is driving abstactly");
        }

        public bool HasTrunk {get; set;}
    }
}
