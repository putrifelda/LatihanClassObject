using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Class
    {
        // propeties
        public string DriverName { get; set; }
        public string onDuty { get; set; }
        public float NumPassenger { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            Console.WriteLine("onDuty: {0}", onDuty);
            Console.WriteLine("NumPassenger: {0}", NumPassenger);
        }
        
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang proses pick up passenger\n", DriverName);
        }
    }
}
