using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Baterie
    {
        public int Stav { get; private set; }

        public void Nabit()
        {
            this.Stav = 100;
        }

        public void Spotrebovat(int hodnota)
        {
            if (this.Stav - hodnota < 0)
                throw new InvalidOperationException("nedostatek kapacity");

            this.Stav -= hodnota;
        }

        public bool Vybita
        {
            get
            {
                return this.Stav <= 0;
            }
        }
    }
}
