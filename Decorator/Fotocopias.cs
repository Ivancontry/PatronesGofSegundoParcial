using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Fotocopias : IComponente
    {
        private IComponente _decoradorA;
        public Fotocopias(IComponente componente)
        {
            _decoradorA = componente;
        }
        public double Costo()
        {
            return _decoradorA.Costo() + 100000;
        }

        public string Funciona()
        {
            return _decoradorA.Funciona() + " Fotocopiadora Lista";
        }

        public override string ToString()
        {
            return "Fotocopias \r\n" + _decoradorA.ToString();
        }
    }
}
