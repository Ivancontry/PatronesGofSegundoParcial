using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Corbatin:Prenda
    {
        public Corbatin(string nombre, double precio)
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
