using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Buildings;
using ConsoleApp1.Vehicles;

namespace ConsoleApp1.Factories
{
    public class SeaFactory : AbstractFactory
    {
        public override AbstractBuilding CreateBuilding()
        {
            return new Rafinery();
        }

        public override AbstractVehicle CreateVehicle()
        {
            return new Ship();
        }
    }
}
