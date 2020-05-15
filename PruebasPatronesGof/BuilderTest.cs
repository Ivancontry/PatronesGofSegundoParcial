using Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    public class BuilderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BuilderTestCase()
        {
            var zona = new Zona("Populandia", "Barrio");
            Cliente cliente = new Cliente.ClienteBuilder("1003195636", "Ivan Contreras", 0)
                .AddAlias("Ivan")
                .AddDireccion("Mz c Casa 19 San Geronimo")
                .AddTelefono("3004558041")
                .AddZona(zona).Build();
            TestContext.WriteLine(cliente.Cedula);
            TestContext.WriteLine(cliente.Nombre);
            TestContext.WriteLine(cliente.Alias);
            TestContext.WriteLine(cliente.Telefono);
            TestContext.WriteLine(cliente.Zona.Nombre);
        }
    }
}
