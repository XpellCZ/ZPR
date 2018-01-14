using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Buildings
{
    public class Warehouse : AbstractBuilding
    {
        public override string Draw()
        {
            return "W" + this.Storage;
        }
    }
}
