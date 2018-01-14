using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Polevka : TekuteJidlo
    {
        public List<Jidlo> Komponenty { get; set; }

        public Polevka()
        {
            this.Komponenty = new List<Jidlo>();
        }

        public override double Teplota
        {
            get
            {
                return base.Teplota;
            }

            set
            {
                foreach (Jidlo item in this.Komponenty)
                {
                    item.Teplota = value;
                }

                base.Teplota = value;
            }
        }
    }
}
