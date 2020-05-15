using NUnit.Framework;
using Prototype.ClonacionProfunda;
using Prototype.ClonacionSuperficial;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasPatronesGof
{
    class PrototypeTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ClonacionSuperficialTestCase()
        {
            //Creamos una camiseta Manga corta
            Camiseta camiseta1 = new CamisetaMangaCorta("Camisilla","S","Blanca","Carro");
            TestContext.WriteLine(camiseta1.Nombre + " -" + camiseta1.Talla + " -" + camiseta1.Color + " -" + camiseta1.Estampado);
          
            //Creamos otra camiseta, de nombre camisilla pero con el resto de atributos diferentes
            //Para esto clonamos la camiseta1
            Camiseta camiseta2 = camiseta1.Clonar();

            //Nos damos cuenta que estos objetos no son iguales
            Assert.AreNotEqual(camiseta1, camiseta2);

            camiseta2.Color = "Negra";
            camiseta2.Talla = "M";
            TestContext.WriteLine(camiseta2.Nombre + " -" + camiseta2.Talla + " -" + camiseta2.Color + " -" + camiseta2.Estampado);


            //Creamos una camiseta Manga Larga
            Camiseta camiseta3 = new CamisetaMangaCorta("Camisa React", "XM", "Blanca", "React");
            TestContext.WriteLine(camiseta3.Nombre + " -" + camiseta3.Talla + " -" + camiseta3.Color + " -" + camiseta3.Estampado);

            //Creamos otra camiseta, de nombre camisilla pero con el resto de atributos diferentes
            //Para esto clonamos la camiseta1
            Camiseta camiseta4 = camiseta3.Clonar();

            //Nos damos cuenta que estos objetos no son iguales
            Assert.AreNotEqual(camiseta3, camiseta4);

            camiseta4.Color = "Negra";
            camiseta4.Talla = "M";
            TestContext.WriteLine(camiseta2.Nombre + " -" + camiseta2.Talla + " -" + camiseta2.Color + " -" + camiseta2.Estampado);
        }

        [Test]
        public void ClonancionProfundaTest() {
            var gerente = new Gerente("Ivan Contreras","3004558041","Mz c casa 19 San Geronimo");
            var empresa1 = new Empresa("System", "Mz c cas 1 Populandia", "3006736783", gerente);

            var empresa2 = empresa1.Clonar();
            Assert.AreNotEqual(empresa1, empresa2);
            var gerente2 = new Gerente("Jorge Contreras", "3004558141", "Mz c casa 19 Mayales");
            empresa2.Gerente = gerente2;

            TestContext.WriteLine(empresa1.Gerente.Nombre);
            TestContext.WriteLine(empresa2.Gerente.Nombre);
        }
    }
}
