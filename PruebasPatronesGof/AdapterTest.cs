using Adapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    class AdapterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdapterTestCase()
        {
            Guitarra guitarraElectrica = new GuitarraElectrica();
            TestContext.WriteLine(guitarraElectrica.Encender());
            TestContext.WriteLine(guitarraElectrica.Apagar());

            TestContext.WriteLine("--------------------------");

            Guitarra guitarraAcustica = new GuitarraElectroAcustica();
            TestContext.WriteLine(guitarraAcustica.Encender());
            TestContext.WriteLine(guitarraAcustica.Apagar());
        }
    }
}
