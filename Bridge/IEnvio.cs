using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    public interface IEnvio
    {
        string Enviar();
        string Entregar();
        string ProcesarPedido();
    }
}
