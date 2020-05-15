using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConexionInalambrica : IComponente
    {
        private IComponente _decoradorC;
        public ConexionInalambrica(IComponente componente)
        {
            _decoradorC = componente;
        }
        public double Costo()
        {
            return _decoradorC.Costo() + 50000;
        }

        public string Funciona()
        {
            return _decoradorC.Funciona() + " Conexión Inalambrica Lista";
        }
        public override string ToString()
        {
            return "Conexión Inalambrica \r\n" + _decoradorC.ToString();
        }
    }
}
