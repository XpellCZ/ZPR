using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> data = new MyList<int>(1, 2, 3, 4, 5, 6, 7, 8, 9);

            string name = "Foo";

            data.Each(x => {
                // closure
                Console.WriteLine(name + x);
            });

            Console.ReadLine();
        }
    }
}
