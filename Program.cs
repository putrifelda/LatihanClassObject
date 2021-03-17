using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugastaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object Taxi
            Taxi taxi = new Taxi();

            // mengeset nilai method
            taxi.DriverName = "Jono";
            taxi.onDuty = true;
            taxi.NumPassengger = 10;

            // penampilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();

            Console.ReadKey();
        }
    }
}
