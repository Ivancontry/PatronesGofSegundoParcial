using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class MacFactory : IComputadorFactory
    {
        public Computer CrearComputadorPC(string ram, string hdd, string cpu)
        {
            return new PcMac(ram, hdd, cpu);
        }

        public Computer CrearComputadorServidor(string ram, string hdd, string cpu)
        {
            return new ServerMac(ram, hdd, cpu);
        }
    }
}
