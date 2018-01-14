using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Generator
    {
        public IWriter Writer { get; set; }

        public Generator(IWriter writer)
        {
            this.Writer = writer;
        }

        public void Save(List<Person> data, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(this.Writer.Before());

                foreach (Person item in data)
                {
                    sw.WriteLine(this.Writer.Row(item));
                }

                sw.WriteLine(this.Writer.After());
            }
        }
    }
}
