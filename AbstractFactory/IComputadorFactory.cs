using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IComputadorFactory
    {
        Computer CrearComputadorPC(string ram, string hdd, string cpu);
        Computer CrearComputadorServidor(string ram, string hdd, string cpu);
    }
}
