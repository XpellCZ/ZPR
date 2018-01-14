using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Buildings
{
    public abstract class AbstractBuilding
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Storage { get; set; }

        public abstract string Draw();
    }
}
