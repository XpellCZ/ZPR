using ConsoleApp1.Buildings;
using ConsoleApp1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public abstract class AbstractFactory
    {
        public abstract AbstractVehicle CreateVehicle();

        public abstract AbstractBuilding CreateBuilding();
    }
}
