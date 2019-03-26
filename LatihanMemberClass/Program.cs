using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Agita";
            taxi.OnDuty = true;
            taxi.NumPassenger = 5;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
