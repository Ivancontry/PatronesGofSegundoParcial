using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ClonacionProfunda
{
    public class Gerente
    {
        public Gerente(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


    }
}
