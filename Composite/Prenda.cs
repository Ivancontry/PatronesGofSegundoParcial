using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Prenda
    {
        public string Color { get; set; }
        public double Precio { get; set; }

        public abstract double GetPrecio();
    }
}
