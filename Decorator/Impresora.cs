using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Impresora : IComponente
    {
        public string Modelo { get; set; }
        public string Caracteristica { get; set; }
        public double Precio { get; set; }
        public Impresora(string modelo, string caracteristica, double costo)
        {
            Modelo = modelo;
            Caracteristica = caracteristica;
            Precio = costo;                       
        }

        public double Costo()
        {
            return this.Precio;
        }

        public string Funciona()
        {
            return "Impresora encendida";
        }

        public override string ToString() {
            return string.Format("Modelo {0}, {1} \r\n", Modelo, Caracteristica);
        }
    }
}
