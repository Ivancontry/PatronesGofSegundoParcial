﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    public abstract class Amazon
    {
        protected IEnvio envio;
        public Amazon(IEnvio envio)
        {
            this.envio = envio;
        }
        public string ProcesarPedido() {
            return envio.ProcesarPedido();
        }
        public string EnviarPedido() {
            return envio.Enviar();
        }
        public string EntregarPedido() {
            return envio.Entregar();
        }

        public void AsignarEnvio(IEnvio envio) { this.envio = envio; }
        public IEnvio ObtenerEnvio() { return this.envio; }
    }

    public enum EnvioDestino {
        EnvioEspaña = 0,
        EnvioMexico = 1,
        EnvioPortugal =2
    }
}
