using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Televize : ElektrickeZarizeni
    {
        public int Kanal { get; private set; }

        public void NastavKanal(int kanal)
        {
            if (!this.Zapnuto)
                throw new InvalidOperationException("neni zapnuto");

            this.Kanal = kanal;
        }
    }
}
