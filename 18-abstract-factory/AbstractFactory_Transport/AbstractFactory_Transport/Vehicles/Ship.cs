using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Vehicles
{
    public class Ship : AbstractVehicle
    {
        public override string Draw()
        {
            return "S" + this.Load;
        }
    }
}
