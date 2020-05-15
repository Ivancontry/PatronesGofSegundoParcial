using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WindowsFactory : IComputadorFactory
    {
        public Computer CrearComputadorPC(string ram, string hdd, string cpu)
        {
            return new PcWindows(ram, hdd, cpu);
        }

        public Computer CrearComputadorServidor(string ram, string hdd, string cpu)
        {
            return new ServerWindows(ram, hdd, cpu);
        }
    }
}
