using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Jidlo
    {
        public bool Zniceno { get; private set; }

        private double _teplota;
        public virtual double Teplota
        {
            get { return _teplota; }
            set
            {
                this._teplota = value;

                if (this._teplota > this.KritickaTeplota())
                    this.Zniceno = true;
            }
        }


        protected virtual int KritickaTeplota()
        {
            return 70;
        }
    }
}
