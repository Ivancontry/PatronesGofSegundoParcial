using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Server : Computer
    {
        public Server(string ram, string cpu,string hdd)
        {           
            this.CPU = cpu;
            this.HDD = hdd;
            this.RAM = ram;
        }        
    }
}
