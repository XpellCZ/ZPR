using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public IRotation Rotation { get; set; }

        public Car(IRotation rotation)
        {
            this.Rotation = rotation;
        }

        public void Draw()
        {
            this.Rotation.Draw();
        }
    }
}
