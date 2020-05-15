using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Scanner:IComponente
    {
        private IComponente _decoradorB;
        public Scanner(IComponente componente)
        {
            _decoradorB = componente;   
        }

        public double Costo()
        {
            return _decoradorB.Costo() + 60000;
        }

        public string Funciona()
        {
            return _decoradorB.Funciona() + " Scanner Listo";
        }

        public override string ToString()
        {
            return "Scanner \r\n" + _decoradorB.ToString();

        }
    }
}
