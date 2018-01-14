using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ElektrickeZarizeni
    {
        public bool Zapnuto { get; private set; }

        public virtual void Zapnout()
        {
            this.Zapnuto = true;
        }

        public virtual void Vypnout()
        {
            this.Zapnuto = false;
        }
    }
}
