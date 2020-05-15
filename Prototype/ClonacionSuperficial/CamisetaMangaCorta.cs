using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ClonacionSuperficial
{
    public class CamisetaMangaCorta : Camiseta
    {
        public CamisetaMangaCorta(string nombre, string talla, string color, string estampado):base(nombre,talla,color,estampado)
        {

        }

        public override Camiseta Clonar()
        {
            return new CamisetaMangaCorta(this.Nombre, this.Talla, this.Color, this.Estampado);
        }

        
    }
}
