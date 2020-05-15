using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Servidor : Computador
    {
        public Servidor(string cpu, string hdd, string ram)
        {
            this.CPU = cpu;
            this.HDD = hdd;
            this.RAM = ram;
            this.ComputadorTipo = ComputadorTipo.Servidor;
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
