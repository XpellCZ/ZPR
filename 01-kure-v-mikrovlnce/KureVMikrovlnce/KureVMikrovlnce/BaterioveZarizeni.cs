﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BaterioveZarizeni : ElektrickeZarizeni
    {
        public Baterie Baterie { get; set; }

        public BaterioveZarizeni()
        {
            this.Baterie = new Baterie();
        }
    }
}
