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
            List<Person> list = new List<Person>() {
                new Person() { Name = "Pepa", Surname = "Novak" },
                new Person() { Name = "Pepa", Surname = "asdfa" },
            };

            Generator g = new Generator(new CsvWriter());
            g.Save(list, @"C:\data.csv");

            g.Writer = new HtmlWriter();
            g.Save(list, @"C:\data.html");
        }
    }
}
