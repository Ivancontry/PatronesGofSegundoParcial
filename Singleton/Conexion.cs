using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Conexion
    {
        private static Conexion _instancia; 
        public Estado Estado { get; set; }
        private Conexion()
        {

        }
        public static Conexion GetInstance()
        {
            if (_instancia == null) {
                _instancia = new Conexion();
            }
            return _instancia;

        }

        public string Conectar() {
            Estado = Estado.Conectado;
            return "Conexión Exitosa";            
        }
        public string Desconectar()
        {
            Estado = Estado.Desconectado;
            return "Desconexion Realizada";           
        }
    }
    public enum Estado { 
        Conectado = 0,
        Desconectado = 1
    }
   
}
