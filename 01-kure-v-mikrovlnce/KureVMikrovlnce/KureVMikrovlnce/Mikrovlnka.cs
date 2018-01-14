using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Mikrovlnka : ElektrickeZarizeni
    {
        public int Casovac { get; private set; }

        public Jidlo Jidlo { get; private set; }

        public void VlozKure(Jidlo k)
        {
            if (this.Jidlo != null)
                throw new InvalidOperationException("plno");

            this.Jidlo = k;
        }

        public Jidlo VyndejKure()

        {
            Jidlo k = this.Jidlo;
            this.Jidlo = null;

            return k;
        }

        public override void Zapnout()
        {
            base.Zapnout();

            this.Jidlo.Teplota = 0.2 * this.Casovac;
            this.Casovac = 0;

            this.Vypnout();
        }

    }
}
