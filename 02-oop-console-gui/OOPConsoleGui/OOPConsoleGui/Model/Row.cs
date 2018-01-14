using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    public class Row
    {
        public List<string> Cells { get; set; }

        public Row()
        {
            this.Cells = new List<string>();
        }

        public Row(string[] data) : this()
        {
            this.Cells = new List<string>(data);
        }
    }
}
