﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ServerLinux: Server
    {
        public ServerLinux(string ram, string cpu, string hdd):base(ram, cpu, hdd)
        {

        }
        public override string ObtenerCPU()
        {
            return this.CPU;
        }

        public override string ObtenerHDD()
        {
            return this.HDD;
        }

        public override string ObtenerRam()
        {
            return this.RAM;
        }
    }
}
