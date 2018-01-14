using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate TOut TransformDelegate<TIn, TOut>(TIn item);

    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> trans = Transform(data, x => x * 2);

            List<string> res = Transform(data, x => x.ToString());

            List<Person> people = new List<Person>() {
                new Person() { Name = "Pepa", Surname = "Novak" },
                new Person() { Name = "Karel", Surname = "Kral" }
            };

            List<string> names = Transform(people, x => x.Name + " " + x.Surname);

            foreach (int item in trans)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }


        static List<TOut> Transform<TIn, TOut>(List<TIn> data, TransformDelegate<TIn, TOut> transform)
        {
            List<TOut> result = new List<TOut>();

            foreach (TIn item in data)
            {
                result.Add(transform(item));
            }

            return result;
        }

    }
}
