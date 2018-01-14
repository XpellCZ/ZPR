using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CsvWriter : IWriter
    {
        public string After()
        {
            return "";
        }

        public string Before()
        {
            return "";
        }

        public string Row(Person person)
        {
            return $"{person.Name};{person.Surname}";
        }
    }
}
