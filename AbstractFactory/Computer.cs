using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Computer
    {
        public string CPU { get; set; }
        public string HDD { get; set; }
        public string RAM { get; set; }
        public abstract string ObtenerRam();
        public abstract string ObtenerHDD();
        public abstract string ObtenerCPU();
    }
  
}
