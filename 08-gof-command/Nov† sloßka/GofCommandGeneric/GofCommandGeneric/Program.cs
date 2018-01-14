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
            List<int> data = new List<int>() { 5, 2, 6, 3, 1, 8, 9, 7 };
            Sorter s = new Sorter();

            data = s.Sort(data, new DescComparator());

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
