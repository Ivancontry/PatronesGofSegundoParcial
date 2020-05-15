using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ClonacionSuperficial
{
    public abstract class Camiseta
    {
        public Camiseta(string nombre, string talla, string color, string estampado)
        {
            this.Nombre = nombre;
            this.Talla = talla;
            this.Color = color;
            this.Estampado = estampado;

        }
        public string Nombre { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }     
        public string Estampado { get; set; }

        public abstract Camiseta Clonar();
       
    }
}
