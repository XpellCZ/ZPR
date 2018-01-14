using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool FilterDelegate<T>(T item);

    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // delegates
            List<int> f = Filter(data, (int item) => item % 2 == 0);

            foreach (int item in f)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            // interface

            List<int> f2 = Filter2(data, new EvenFilter());

            foreach (int item in f2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }


        static List<T> Filter<T>(List<T> data, FilterDelegate<T> filterFunc)
        {
            List<T> filtered = new List<T>();

            foreach (T item in data)
            {
                if (filterFunc(item))
                    filtered.Add(item);
            }

            return filtered;
        }

        static List<T> Filter2<T>(List<T> data, IFilter<T> filter)
        {
            List<T> filtered = new List<T>();

            foreach (T item in data)
            {
                if (filter.Filter(item))
                    filtered.Add(item);
            }

            return filtered;
        }
    }
}
