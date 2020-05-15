using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Computador
    {
        
        public ComputadorTipo ComputadorTipo {get;set;}
        public string CPU { get; set; }
        public string HDD { get; set; }
        public string RAM { get; set; }
        public abstract string GetRam();
        public abstract string GetHDD();
        public abstract string GetCPU();
    }

    public enum ComputadorTipo { 
        PC=0,
        Servidor=1
    }
}
