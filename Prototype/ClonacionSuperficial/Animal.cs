using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ClonacionSuperficial
{
    public class Animal: ICloneable
    {
        public Animal(string nombre, int patas)
        {

        }
        public int Patas { get; set; }
        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
