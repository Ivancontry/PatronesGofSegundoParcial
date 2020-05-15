using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class GuitarraElectroAcustica : Guitarra
    {
        private GuitarraAcustica _guitarraAcustica = new GuitarraAcustica();
        public override string Apagar()
        {
           return _guitarraAcustica.Tocar();
        }

        public override string Encender()
        {
           return _guitarraAcustica.DejarTocar();
        }
    }
}
