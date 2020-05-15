using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(ClienteBuilder builder)
        {
            Cedula = builder.Cedula;
            Nombre = builder.Nombre;
            Alias = builder.Alias;
            Direccion = builder.Direccion;
            Telefono = builder.Telefono;
            ZonaId = builder.ZonaId;
            Zona = builder.Zona;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int ZonaId { get; set; }
        public Zona Zona { get; set; }

        public class ClienteBuilder{
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Alias { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; } 
            public int ZonaId { get; set; }
            public Zona Zona { get; set; }
            public ClienteBuilder(string cedula,string nombre, int zonaID)
            {
                this.Cedula = cedula;
                this.Nombre = nombre;
                this.ZonaId = zonaID;
            }
            public ClienteBuilder AddAlias(string alias)
            {
                Alias = alias;
                return this;
            }
            public ClienteBuilder AddDireccion(string direccion)
            {
                this.Direccion = direccion;
                return this;
            }
            public ClienteBuilder AddTelefono(string telefono)
            {
                this.Telefono = telefono;
                return this;
            }
            public ClienteBuilder AddZona(Zona zona) {
                this.Zona = zona;
                return this;
            }

            public Cliente Build() {
                Cliente cliente = new Cliente(this);
                return cliente;
            }
        }
    }
}

