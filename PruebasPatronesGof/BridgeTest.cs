using BridgeEnvios;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    class BridgeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BridgeTestCase()
        {
            var destinoEnvio = RepartoAmazon.CrearEnvio(EnvioDestino.EnvioEspaña);
            RepartoAmazon repartoAmazon = new RepartoAmazon("1", destinoEnvio);
            //Enviamos el pedido a España por defecto
            TestContext.WriteLine(repartoAmazon.EnviarPedido());
            TestContext.WriteLine(repartoAmazon.ProcesarPedido());
            TestContext.WriteLine(repartoAmazon.EntregarPedido());



            //Ahora queremos enviar el pedido a Mexico
            destinoEnvio = RepartoAmazon.CrearEnvio(EnvioDestino.EnvioMexico);
            repartoAmazon.AsignarEnvio(destinoEnvio);
            TestContext.WriteLine(repartoAmazon.EnviarPedido());
            TestContext.WriteLine(repartoAmazon.ProcesarPedido());
            TestContext.WriteLine(repartoAmazon.EntregarPedido());
        }
    }
}
