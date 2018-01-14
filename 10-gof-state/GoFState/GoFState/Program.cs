using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new UpRotation());

            car.Draw();

            car.Rotation = new RightRotation();

            car.Draw();

            Console.ReadLine();
        }
    }
}
