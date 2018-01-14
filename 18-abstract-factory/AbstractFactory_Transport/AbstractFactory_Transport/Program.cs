using ConsoleApp1.Factories;
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
            //Game g = new Game(new SeaFactory());
            Game g = new Game(new LandFactory());

            while (true)
            {
                g.Draw();
                g.OnKey(Console.ReadKey().Key);
            }
        }
    }
}
