using AbstractFactory;
using NUnit.Framework;

namespace PruebasPatronesGof
{

    class AbstractFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void AbstractMethodTest()
        {
            IComputadorFactory computadorFactory = new WindowsFactory();
            var pcWindows = computadorFactory.CrearComputadorPC("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(pcWindows.GetType().Name);
            TestContext.WriteLine(pcWindows.ObtenerHDD());
            TestContext.WriteLine(pcWindows.ObtenerRam());
            TestContext.WriteLine(pcWindows.ObtenerCPU());

            var serverWindows = computadorFactory.CrearComputadorServidor("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(serverWindows.GetType().Name);
            TestContext.WriteLine(serverWindows.ObtenerHDD());
            TestContext.WriteLine(serverWindows.ObtenerRam());
            TestContext.WriteLine(serverWindows.ObtenerCPU());


            computadorFactory = new MacFactory();
            var pcMac = computadorFactory.CrearComputadorPC("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(pcMac.GetType().Name);
            TestContext.WriteLine(pcMac.ObtenerHDD());
            TestContext.WriteLine(pcMac.ObtenerRam());
            TestContext.WriteLine(pcMac.ObtenerCPU());

            var serverMac = computadorFactory.CrearComputadorServidor("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(serverMac.GetType().Name);
            TestContext.WriteLine(serverMac.ObtenerHDD());
            TestContext.WriteLine(serverMac.ObtenerRam());
            TestContext.WriteLine(serverMac.ObtenerCPU());

            computadorFactory = new LinuxFactory();
            var pcLinux = computadorFactory.CrearComputadorPC("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(pcLinux.GetType().Name);
            TestContext.WriteLine(pcLinux.ObtenerHDD());
            TestContext.WriteLine(pcLinux.ObtenerRam());
            TestContext.WriteLine(pcLinux.ObtenerCPU());

            var serverLinux = computadorFactory.CrearComputadorServidor("2 GB", "500 GB", "2.4 Ghz");
            TestContext.WriteLine(serverLinux.GetType().Name);
            TestContext.WriteLine(serverLinux.ObtenerHDD());
            TestContext.WriteLine(serverLinux.ObtenerRam());
            TestContext.WriteLine(serverLinux.ObtenerCPU());

            Assert.IsTrue(pcLinux is Pc);
            Assert.IsTrue(serverLinux is Server);
            Assert.IsTrue(pcWindows is Pc);
            Assert.IsTrue(serverWindows is Server);
            Assert.IsTrue(pcMac is Pc);
            Assert.IsTrue(serverMac is Server);
        }
    }
}
