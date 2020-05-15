using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class LinuxFactory : IComputadorFactory
    {
        public Computer CrearComputadorPC(string ram, string hdd, string cpu)
        {
            return new PcLinux(ram, hdd, cpu);
        }

        public Computer CrearComputadorServidor(string ram, string hdd, string cpu)
        {
            return new ServerLinux( ram, hdd, cpu);
        }
    }
}
