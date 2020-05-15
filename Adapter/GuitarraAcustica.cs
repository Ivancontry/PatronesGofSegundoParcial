using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class GuitarraAcustica
    {
        public string Tocar() {
            return "Tocando";
        }
        public string DejarTocar()
        {
            return "Silencio";
        }
    }
}
