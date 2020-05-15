using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Saco:Prenda
    {
        public Saco(string nombre,double precio)
        {
            Color = nombre;
            Precio = precio;
        }

        public override double GetPrecio()
        {
            return this.Precio;
        }
    }
}
