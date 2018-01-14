using ConsoleApp1.Factories;
using ConsoleApp1.Vehicles;
using ConsoleApp1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private AbstractVehicle vehicle;

        private List<AbstractBuilding> buildings = new List<AbstractBuilding>();

        public Game(AbstractFactory factory)
        {
            this.vehicle = factory.CreateVehicle();
            this.vehicle.Capacity = 10;

            for (int i = 0; i < 5; i++)
            {
                AbstractBuilding b = factory.CreateBuilding();
                b.X = (i + 1) * 4;
                b.Y = (i * 3);
                b.Storage = 100;

                this.buildings.Add(b);
            }
        }

        public void Draw()
        {
            try
            {
                Console.Clear();

                // vehicle
                Console.SetCursorPosition(this.vehicle.X, this.vehicle.Y);
                Console.Write(this.vehicle.Draw());

                foreach (AbstractBuilding item in this.buildings)
                {
                    Console.SetCursorPosition(item.X, item.Y);
                    Console.Write(item.Draw());
                }
            }
            catch
            {

            }
        }

        public void OnKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    this.vehicle.Y--;
                    break;

                case ConsoleKey.DownArrow:
                    this.vehicle.Y++;
                    break;

                case ConsoleKey.LeftArrow:
                    this.vehicle.X--;
                    break;

                case ConsoleKey.RightArrow:
                    this.vehicle.X++;
                    break;
            }

            foreach (AbstractBuilding item in this.buildings)
            {
                if (item.X == this.vehicle.X && item.Y == this.vehicle.Y)
                {
                    if (this.vehicle.Load == 0)
                        this.vehicle.FullLoad(item);
                    else
                        this.vehicle.Unload(item);
                }
            }
        }
    }
}
