using FactoryMethod;
using NUnit.Framework;

namespace PruebasPatronesGof
{
    public class FactoryMethod
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FactoryMethodTest()
        {
            Computador pc = ComputadorFabrica.GetComputador(ComputadorTipo.PC, "2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine("Computador de tipo " + pc.GetType().Name);
            TestContext.WriteLine(pc.GetHDD());
            TestContext.WriteLine(pc.GetRam());
            TestContext.WriteLine(pc.GetCPU());

            Computador server = ComputadorFabrica.GetComputador(ComputadorTipo.Servidor, "20 GB", "2 TB", "2.9 Ghz");
            TestContext.WriteLine("Computador de tipo " + server.GetType().Name);
            TestContext.WriteLine(server.GetHDD());
            TestContext.WriteLine(server.GetRam());
            TestContext.WriteLine(server.GetCPU());


            Assert.AreEqual(pc.GetType().Name, "PC");
            Assert.AreEqual(server.GetType().Name, "Servidor");
        }
    }
}