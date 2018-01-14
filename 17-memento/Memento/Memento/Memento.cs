using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Memento
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Memento(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
