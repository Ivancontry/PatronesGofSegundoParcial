using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class GuitarraElectrica : Guitarra
    {
        public override string Apagar()
        {
            return "Tocando";
        }

        public override string Encender()
        {
            return "Silencio";
        }
    }
}
