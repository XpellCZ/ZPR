using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Buildings
{
    public class Rafinery : AbstractBuilding
    {
        public override string Draw()
        {
            return "R" + this.Storage;
        }
    }
}
