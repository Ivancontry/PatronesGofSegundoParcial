using NUnit.Framework;
using Singleton;

namespace PruebasPatronesGof
{
    class SingletonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingletonTestCase()
        {
            //Creamos una instancia 1
            TestContext.WriteLine("Creamos una instancia 1");
            Conexion instancia1 = Conexion.GetInstance();
            TestContext.WriteLine("Realizamos la conexion");
            TestContext.WriteLine(instancia1.Conectar());

            TestContext.WriteLine("Creamos una instancia 2");
            Conexion instancia2 = Conexion.GetInstance();

            //Observamos que el estado de la instancia 2 es igual al estado de la instancia 1,
            //debido a que es al misma instancia
            TestContext.WriteLine("Estado de la instancia 1");
            TestContext.WriteLine(instancia1.Estado);

            TestContext.WriteLine("Estado de la instancia 2");
            TestContext.WriteLine(instancia2.Estado);

            Assert.AreEqual(instancia1.Estado, instancia2.Estado);
        }
    }
}
