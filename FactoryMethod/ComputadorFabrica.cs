using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ComputadorFabrica
    {
        public static Computador GetComputador(ComputadorTipo tipo, string cpu,string hdd,string ram ) {
            Computador computador = null;
            switch (tipo)
            {
                case ComputadorTipo.PC:
                    computador = new PC(cpu, hdd, ram);
                    break;
                case ComputadorTipo.Servidor:
                    computador = new Servidor(cpu, hdd, ram);
                    break;
            }
            return computador;
        }
    }
}
