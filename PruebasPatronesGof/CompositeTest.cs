using Composite;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    class CompositeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CompositeTestCase()
        {
            Prenda camisa = new Camisa("Blanca",50000);
            TestContext.WriteLine("Precio Camisa: "+camisa.GetPrecio());
            Prenda chaleco = new Chaleco("Negro", 40000);
            TestContext.WriteLine("Precio Chaleco: " + chaleco.GetPrecio());
            Prenda corbatin = new Corbatin("Negro", 30000);
            TestContext.WriteLine("Precio Corbatin: " + corbatin.GetPrecio());
            Prenda correa = new Correa("Negra", 30000);
            TestContext.WriteLine("Precio Correa: " + correa.GetPrecio());
            Prenda pantalon = new Pantalon("Negro", 60000);
            TestContext.WriteLine("Precio Pantalon: " + pantalon.GetPrecio());
            Prenda saco = new Saco("Negro", 150000);
            TestContext.WriteLine("Precio Saco: " + saco.GetPrecio());

            Esmoquin esmoquin = new Esmoquin("Negro-Blanco");
            esmoquin.AddPrenda(camisa);
            esmoquin.AddPrenda(chaleco);
            esmoquin.AddPrenda(corbatin);
            esmoquin.AddPrenda(correa);
            esmoquin.AddPrenda(pantalon);
            esmoquin.AddPrenda(saco);

            TestContext.WriteLine("Precio Esmoquin: " + esmoquin.GetPrecio());


        }
    }
}
