using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Vehicles
{
    public class Truck : AbstractVehicle
    {
        public override string Draw()
        {
            return "T" + this.Load;
        }
    }
}
