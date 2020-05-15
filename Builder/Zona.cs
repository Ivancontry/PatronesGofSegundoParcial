using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Zona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
     

        public Zona(string nombre, string descripcion)
        {
            this.Id = 0;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
    }
}
