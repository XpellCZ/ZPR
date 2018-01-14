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
            List<int> data = new List<int>() { 5, 2, 4, 8, 1, 6, 3 };
            Sorter s = new Sorter();

            // delegati
            CompareDelegate x = SortAsc;
            CompareDelegate y = delegate(object a, object b) {
                return true;
            };
            CompareDelegate z = (object a, object b) => true;
            CompareDelegate zz = (object a, object b) => { Console.WriteLine("xxx"); return true; };

            data = s.Sort(data, (object a, object b) => true);

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();        
        }


        static bool SortAsc(object a, object b)
        {
            return Convert.ToInt32(a) > Convert.ToInt32(b);
        }
    }
}
