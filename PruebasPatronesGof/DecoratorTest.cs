using Decorator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    class DecoratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DecoratorTestCase()
        {
            IComponente impresora = new Impresora("2019", "Blanca", 100000);

            TestContext.WriteLine(impresora.ToString());
            TestContext.WriteLine(impresora.Costo());
            TestContext.WriteLine(impresora.Funciona());

            TestContext.WriteLine("-----------------------");

            //decoramos la impresora con las diferentes funcionalidades

            //Fotocopiadora
            impresora = new Fotocopias(impresora);
            TestContext.WriteLine(impresora.ToString());
            TestContext.WriteLine(impresora.Costo());
            TestContext.WriteLine(impresora.Funciona());

            TestContext.WriteLine("-----------------------");

            //Scanner
            impresora = new Scanner(impresora);
            TestContext.WriteLine(impresora.ToString());
            TestContext.WriteLine(impresora.Costo());
            TestContext.WriteLine(impresora.Funciona());

            TestContext.WriteLine("-----------------------");

            //Conexion Inalambrica
            impresora = new ConexionInalambrica(impresora);
            TestContext.WriteLine(impresora.ToString());
            TestContext.WriteLine(impresora.Costo());
            TestContext.WriteLine(impresora.Funciona());

        }
    }
}
