using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Camisa:Prenda
    {
        public Camisa(string nombre, double precio)
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
