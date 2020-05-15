using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PC : Computador
    {
        public PC(string cpu, string hdd, string ram)
        {
            this.CPU = cpu;
            this.HDD = hdd;
            this.RAM = ram;
            this.ComputadorTipo = ComputadorTipo.PC;
        }
        public override string GetCPU()
        {
            return this.CPU;
        }

        public override string GetHDD()
        {
            return this.HDD;
        }

        public override string GetRam()
        {
            return this.RAM;
        }
    }
}
