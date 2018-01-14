using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MobilniTelefon : BaterioveZarizeni
    {
        public List<string> OdchoziHovory { get; private set; }

        public MobilniTelefon()
        {
            this.OdchoziHovory = new List<string>();
        }

        public void Zavolej(string cislo)
        {
            this.Baterie.Spotrebovat(5);
            this.OdchoziHovory.Add(cislo);

            if (this.Baterie.Vybita)
                this.Vypnout();
        }

        public override void Vypnout()
        {
            this.OdchoziHovory.Clear();
            base.Vypnout();
        }
    }
}
