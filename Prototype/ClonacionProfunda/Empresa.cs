using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ClonacionProfunda
{
    public class Empresa
    {
        public Empresa(string nombre, string direccion, string telefono, Gerente gerente)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Gerente = gerente;
        }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Gerente Gerente { get; set; }
        public Empresa Clonar() {
            var empresa = this.MemberwiseClone() as Empresa;
            var gerente = new Gerente(this.Gerente.Nombre, this.Gerente.Telefono, this.Gerente.Direccion);
            empresa.Gerente = gerente;
            return empresa;
        }
    }
}
