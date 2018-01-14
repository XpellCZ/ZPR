using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Popcorn : PevneJidlo
    {
        public List<KukuricneZrno> Zrna { get; set; }

        public Popcorn()
        {
            this.Zrna = new List<KukuricneZrno>();
        }

        public override double Teplota
        {
            get
            {
                return base.Teplota;
            }

            set
            {
                foreach (KukuricneZrno item in this.Zrna)
                {
                    item.Teplota = value;
                }

                base.Teplota = value;
            }
        }
    }
}
