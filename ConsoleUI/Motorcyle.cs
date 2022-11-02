using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} is driving virtual");
        }

        public bool HasSideCart { get; set; }
    }
}
