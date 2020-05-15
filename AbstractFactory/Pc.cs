using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pc : Computer
    {
        public Pc(string ram, string cpu, string hdd)
        {            
            this.CPU = cpu;
            this.HDD = hdd;
            this.RAM = ram;
        }
      
    }
}
