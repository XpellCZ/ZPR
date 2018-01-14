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
            Game g1 = Game.GetInstance();
            Game g2 = Game.GetInstance();

            Console.WriteLine(g1 == g2);

            Connection c1 = Connection.Instance;
            Connection c2 = Connection.Instance;

            Console.WriteLine(c1 == c2);


            Console.ReadLine();
        }
    }
}
