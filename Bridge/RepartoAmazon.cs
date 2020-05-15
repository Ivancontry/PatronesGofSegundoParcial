using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    public class RepartoAmazon:Amazon 
    {
        private string _numeroPedido;
        public RepartoAmazon(string idPedido, IEnvio envio):base(envio)
        {
            _numeroPedido = idPedido;
        }
        public static IEnvio CrearEnvio(EnvioDestino envio)
        {
            IEnvio Ienvio = null;
            switch (envio)
            {
                
                case EnvioDestino.EnvioEspaña:
                    Ienvio = new EnvioEspaña();
                    break;
                case EnvioDestino.EnvioMexico:
                    Ienvio = new EnvioMexico();
                    break;
                case EnvioDestino.EnvioPortugal:
                    Ienvio = new EnvioPortugal();
                    break;
            }
            return Ienvio;
        }
    }
}