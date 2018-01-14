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
            MyList data = new MyList(1, 2, 3, 4, 5, 6, 7, 8, 9);

            IMyIterator iterator = data.GetIterator();
            while (iterator.HasNext())
            {
                int item = iterator.GetNext();
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---");
            
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // foreach
            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int item = enumerator.Current;
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
