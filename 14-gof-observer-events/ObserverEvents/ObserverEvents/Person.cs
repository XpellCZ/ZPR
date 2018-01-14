using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person : IBulbObserver
    {
        public void OnFire(Bulb sender)
        {
            Console.WriteLine("Person: on fire");
        }


        public void FF(Bulb sender)
        {
            Console.WriteLine("Person: FF");
        }
    }
}
