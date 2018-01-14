using ConsoleApp1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Vehicles
{
    public abstract class AbstractVehicle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Capacity { get; set; }

        public int Load { get; set; }

        public abstract string Draw();

        public void FullLoad(AbstractBuilding building)
        {
            int load = Math.Min(this.Capacity, building.Storage);

            building.Storage -= load;
            this.Load += load;
        }

        public void Unload(AbstractBuilding building)
        {
            building.Storage += this.Load;
            this.Load = 0;
        }
    }
}
