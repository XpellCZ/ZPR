using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HtmlWriter : IWriter
    {
        public string After()
        {
            return "</table>";
        }

        public string Before()
        {
            return "<table>";
        }

        public string Row(Person person)
        {
            return $"<tr><td>{person.Name}</td><td>{person.Surname}</td></tr>";
        }
    }
}
