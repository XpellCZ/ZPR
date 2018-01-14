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
            Bulb b1 = new Bulb();
            Bulb b2 = new Bulb();
            Person p = new Person();

            
            // observer
            b1.RegisterObserver(p);
            b2.RegisterObserver(p);

            // del[]
            b1.RegisterDelegate(p.FF);
            b2.RegisterDelegate(p.FF);

            // event
            b1.OnFire += p.FF;
            b2.OnFire += p.FF;

            b1.Fire();


            Console.ReadLine();
        }

        public void bntClick(object sender, EventArgs e)
        {

        }
    }
}
