using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    public class Table
    {
        public List<string> Header { get; set; }

        public List<Row> Rows { get; set; }

        public Table()
        {
            this.Header = new List<string>();
            this.Rows = new List<Row>();
        }

        public void Load(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                bool first = true;
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');

                    if (first)
                    {
                        this.Header = new List<string>(line);
                        first = false;
                        continue;
                    }

                    if (line.Length != this.Header.Count)
                        throw new InvalidOperationException("Header and data row columns count mismatch");

                    Row r = new Model.Row(line);
                    this.Rows.Add(r);
                }
            }
        }
    }
}
